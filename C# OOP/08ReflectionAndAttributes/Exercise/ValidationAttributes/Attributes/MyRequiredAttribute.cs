namespace ValidationAttributes.Attributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool isValid(object objProperty)
        {
            return objProperty != null;
        }
    }
}