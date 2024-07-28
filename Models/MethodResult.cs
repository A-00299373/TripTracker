﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.Models
{
    /// <summary>
    /// Represents the outcome of a method execution in the TripTracker application.
    /// This struct includes a boolean indicator (IsSuccess) to denote whether
    /// the method execution was successful, and an optional error message (Error)
    /// that provides details in case of failure. It's used to standardize
    /// the handling of method results across the application.
    /// </summary>
    public readonly record struct MethodResult(bool IsSuccess, string? Error)
    {
        public static MethodResult Success() => new(true, null);
        public static MethodResult Fail(string? error) => new(false, error);
    }
}
