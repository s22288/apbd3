namespace apbd3.functions
{
    public class ValidateId
    {
        public static bool validateId(string id)
        {
            if (id[0] != 's')
            {
                return false;
            }
            if (id.Length != 6)
            {
                return false;
            }

            if(!id.Substring(1, id.Length - 1).All(char.IsDigit)){
                return false;
            }

            return true;
        }
    }
}
