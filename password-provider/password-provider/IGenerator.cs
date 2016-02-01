namespace password_provider
{
    using System;

    public interface IGenerator
    {
        IResult GenerateNext();
    }
}
