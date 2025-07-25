﻿namespace Persistence.Configurations
{
    internal static class TableNames
    {
        internal const string User = nameof(User);
        internal static class UserTable
        {
            internal const string Id = nameof(Id);
            internal const string Username = nameof(Username);
            internal const string Email = nameof(Email);
            internal const string PasswordHash = nameof(PasswordHash);
        }
    }
}
