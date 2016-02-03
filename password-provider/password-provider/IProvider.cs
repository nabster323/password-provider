namespace password_provider
{
    using System;

    public interface IProvider
    {
        string Describe { get; }
    }
}