﻿namespace TaskManagementSystem_BL.Exceptions
{
    public interface IBaseException
    {
        int StatusCode {  get; }
        string ErrorMessage { get; }
    }
}
