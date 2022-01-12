using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DynamicBox.Workflow.Shared.Dtos
{
    public class ServiceResponse<T>
    {
        public T Data { get; private set; }
        public List<string> Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }


        //static factory method
        public static ServiceResponse<T> Success(T data, int statusCode)
        {
            return new ServiceResponse<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static ServiceResponse<T> Success(int statusCode)
        {
            return new ServiceResponse<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }


        public static ServiceResponse<T> Fail(List<string> errors, int statusCode)
        {
            return new ServiceResponse<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        public static ServiceResponse<T> Fail(string error, int statusCode)
        {
            return new ServiceResponse<T>
            {
                Errors = new List<string>() { error },
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

    }
}
