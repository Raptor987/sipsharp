using System;

namespace SipSharp.Logging
{
    /// <summary>
    /// Factory creating null logger.
    /// </summary>
    public class NullLogFactory : ILogFactory
    {
        private static NullLogFactory _instance = new NullLogFactory();

        private NullLogFactory()
        {}


        #region ILogFactory Members

        /// <summary>
        /// Create a new logger.
        /// </summary>
        /// <param name="type">Type that requested a logger.</param>
        /// <returns>Logger for the specified type;</returns>
        /// <remarks>
        /// MUST ALWAYS return a logger. Return <see cref="NullLogger"/> if no logging
        /// should be used.
        /// </remarks>
        public ILogger CreateLogger(Type type)
        {
            return new NullLogger();
        }

        #endregion

        public static ILogFactory Instance
        {
            get { return _instance; }
        }
    }
}