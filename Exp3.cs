namespace Revolt2D.Exp.Json
{
    public class Exp3
    {
        public string Type;
        public List<Parameter> Parameters;

        public override string ToString()
        {
            string parametersString = string.Join(
                "\n",
                Parameters.Select((p, i) => $"  Parameter[{i}]:\n{p}")
            );
            return $"Type: {Type}\nParameters:\n{parametersString}";
        }
    }
}
