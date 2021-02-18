namespace ObfuscarTest
{
    internal class GenericClass<T1>
    {
        public void Process<T2>(ref T2 other)
        {
        }

        public void Process()
        {
        }
    }

    internal class TypeParamClass
    {
    }

    public class TestClass
    {
        public static void Test()
        {
            var operation = new GenericClass<TypeParamClass>();
            var param = new TypeParamClass();
            operation.Process(ref param);
        }
    }
}
