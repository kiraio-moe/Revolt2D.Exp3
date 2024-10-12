namespace Revolt2D.Exp.Json
{
    public class Parameter
    {
        public string Id;
        public int Value;
        public string Blend;

        public override string ToString()
        {
            return $"    Id: {Id}\n    Value: {Value}\n    Blend: {Blend}";
        }
    }
}
