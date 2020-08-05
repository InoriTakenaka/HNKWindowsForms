namespace HNKCore.Proto {
    public class ResponseModel {
        public ResponseModel() {
            Code = 0;
            Message = "请求失败";
            DataCount = 0;
        }

        public int Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public int DataCount { get; set; }
    }
}
