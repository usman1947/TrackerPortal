namespace WebApi.Entities
{
    public class ResultLog
    {
        public bool Success { get; set; } = true;
        public int Code { get; set; }
        public int Count { get; set; }
        public string Message { get; set; } = TranslationConstant._OPERATION_SUCCESS;
        public ResultLog() {}
        public ResultLog(bool success, int code, string message, int count = 0)
        {
            Success = success;
            Code = code;
            Message = message;
            Count = count;
        }

        public static ResultLog CreateSuccess()
        {
            return CreateSuccess(TranslationConstant._OPERATION_SUCCESS);
        }

        public static ResultLog CreateSuccess(string message)
        {
            return new ResultLog(true, 0, message);
        }

        public static ResultLog CreateFail()
        {
            return CreateFail(TranslationConstant._OPERATION_FAIL, "");
        }

        public static ResultLog CreateFail(string message, string detail = "")
        {
            return CreateFail(-1, message, detail);
        }

        public static ResultLog CreateFail(int code, string message)
        {
            return CreateFail(code, message, message);
        }

        public static ResultLog CreateFail(int code, string message, string detail)
        {
            return new ResultLog(false, code, message, 0);
        }
    }

    public class ResultLog<T> : ResultLog
    {
        public T Data { get; set; }

        public ResultLog() { }
        public ResultLog(bool success, int code, string message, T data = default, int count = 0)
            : base(success, code, message, count)
        {
            Data = data;
        }
        public static ResultLog<T> CreateSuccess(string message = "Operation Success", T data = default, int count = 0)
        {
            return new ResultLog<T>(true, 0, message, data, count);
        }

        public static ResultLog<T> CreateFail(string message)
        {
            return CreateFail(message, default);
        }

        public static ResultLog<T> CreateFail(string message, T data)
        {
            return CreateFail(message, message, data);
        }

        public static ResultLog<T> CreateFail(string message = "Operation Fail", string detail = "Operation Fail", T data = default, int count = 0)
        {
            return new ResultLog<T>(false, -1, message, data, count);
        }

        public static ResultLog<T> CreateFail(string message = "Operation Fail", T data = default, int count = 0)
        {
            return new ResultLog<T>(false, -1, message, data, count);
        }
    }
}
