namespace build.attributes
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
    sealed class Category : System.Attribute
    {
        readonly string positionalString;

        // This is a positional argument
        public Category(string positionalString)
        {
            this.positionalString = positionalString;
        }

        public string PositionalString => positionalString;

        // This is a named argument
        public int NamedInt { get; set; }
    }
}
