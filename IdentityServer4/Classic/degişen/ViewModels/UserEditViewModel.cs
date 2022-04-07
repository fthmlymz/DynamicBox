namespace DynamicBox.IdentityServer.ViewModels
{
    public class UserEditViewModel: UserCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
