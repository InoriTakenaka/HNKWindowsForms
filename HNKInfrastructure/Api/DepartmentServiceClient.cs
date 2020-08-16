using HNKCore.Proto;
using System.Collections;
namespace HNKInfrastructure.Api {
    public class DepartmentServiceClient:RestClient {
        public DepartmentServiceClient(string url) : base(url) {

        }
        public ResponseModel GetDepartments() {
            return RequestGet("FetchDepartments", null);
        }
        public ResponseModel InsertDepartment(Department department) {
            return RequestPut("InsertDepartment", department);
        }
    }
}
