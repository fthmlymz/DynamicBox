import { TestBed } from '@angular/core/testing';

import { MaterialDemandService } from './material-demand.service';

describe('MaterialDemandService', () => {
  let service: MaterialDemandService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MaterialDemandService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
