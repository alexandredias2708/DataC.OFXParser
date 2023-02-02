using System;

namespace OFXParser.Core
{
    class OFXParserException : Exception
    {
        public OFXParserException(String message, Exception inner) : base(message, inner)
        {

        }
    }
}
