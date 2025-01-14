﻿using AirBnb.Application.RequestContexts.Models;

namespace AirBnb.Application.RequestContexts.Brokers;

/// <summary>
/// Defines request context broker functionalities
/// </summary>
public interface IRequestContextProvider
{
    /// <summary>
    /// Retrieves request context
    /// </summary>
    /// <returns>Request context</returns>
    RequestContext GetRequestContext();
}