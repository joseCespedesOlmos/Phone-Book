using System;

namespace DatabaseStorage
{
    internal class SqlCommand
    {
        private string v;

        public SqlCommand(string v, object con)
        {
            this.v = v;
        }

        public object CommandType { get; internal set; }
        public object Parameters { get; internal set; }
        public object AddWithValue { get; internal set; }
        public object GetType { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}