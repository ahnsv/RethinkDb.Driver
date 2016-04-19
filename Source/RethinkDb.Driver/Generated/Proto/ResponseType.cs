


//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

namespace RethinkDb.Driver.Proto {
    public enum ResponseType {
        SUCCESS_ATOM = 1,
        SUCCESS_SEQUENCE = 2,
        SUCCESS_PARTIAL = 3,
        WAIT_COMPLETE = 4,
        SERVER_INFO = 5,
        CLIENT_ERROR = 16,
        COMPILE_ERROR = 17,
        RUNTIME_ERROR = 18,
    }

    
       public static class ExtensionsForResponseType {
            public static bool IsError(this ResponseType rtype){
                 switch( rtype ){
                        case ResponseType.CLIENT_ERROR:
                            return true;
                        case ResponseType.COMPILE_ERROR:
                            return true;
                        case ResponseType.RUNTIME_ERROR:
                            return true;
                    default:
                        return false;
                 }
            }
      }


}
