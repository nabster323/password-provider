namespace password_provider
{
    using System.Collections.Generic;

    public interface ICharacterSets
    {
        IEnumerable<char> allowedCharacters { get; }
    }
}
