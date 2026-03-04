// TODO: define the 'AccountType' enum
using System.Reflection.Metadata.Ecma335;

enum AccountType
{
    Guest,
    User,
    Moderator,
}

// TODO: define the 'Permission' enum
[Flags]
enum Permission : byte
{
    None = 0b00000000,
    Read = 0b00000001,
    Write = 0b00000010,
    Delete = 0b00000100,
    All = Read | Write | Delete,
}
static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest: return Permission.Read;
            case AccountType.User: return Permission.Read | Permission.Write;
            case AccountType.Moderator: return Permission.Read | Permission.Write | Permission.Delete;          
            default: return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant) => current | grant;
    public static Permission Revoke(Permission current, Permission revoke)
    {
        if ((current & Permission.Read) != 0 && (revoke & Permission.Read) != 0)
        {
            current -= Permission.Read;
        }
        if ((current & Permission.Write) != 0 && (revoke & Permission.Write) != 0)
        {
            current -= Permission.Write;
        }
        if ((current & Permission.Delete) != 0 && (revoke & Permission.Delete) != 0)
        {
            current -= Permission.Delete;
        }

        return current;
    }
    public static bool Check(Permission current, Permission check) => current.HasFlag(check);
}
