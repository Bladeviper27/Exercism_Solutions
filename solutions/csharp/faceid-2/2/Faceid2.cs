public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        FacialFeatures facialFeatures = obj as FacialFeatures;
        return (facialFeatures.EyeColor == this.EyeColor) && (facialFeatures.PhiltrumWidth == this.PhiltrumWidth);
    }
    public override int GetHashCode() => HashCode.Combine(this.EyeColor, this.PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        Identity identity = obj as Identity;
        return identity.Email == this.Email && this.FacialFeatures.Equals(identity.FacialFeatures);
    }

    public override int GetHashCode() => HashCode.Combine(this.Email, this.FacialFeatures);
}

public class Authenticator
{
    HashSet<Identity> identities = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
    public bool IsAdmin(Identity identity) => identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    public bool Register(Identity identity) => identities.Add(identity);
    public bool IsRegistered(Identity identity) => identities.Contains(identity);
    public static bool AreSameObject(Identity identityA, Identity identityB) => (identityA == identityB);
}
