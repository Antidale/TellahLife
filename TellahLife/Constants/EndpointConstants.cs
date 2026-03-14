using System;

namespace TellahLife.Constants;

public class EndpointConstants
{
#if DEBUG
    // public const string API_BASE_ADDRESS = "http://localhost:8085/api";
    public const string API_BASE_ADDRESS = "https://free-enterprise-info-api.herokuapp.com/api";
#else
    public const string API_BASE_ADDRESS = "https://free-enterprise-info-api.herokuapp.com/api";
#endif
}
