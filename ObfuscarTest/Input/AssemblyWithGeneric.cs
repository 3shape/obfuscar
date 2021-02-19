namespace ObfuscarTest
{
    internal class GenericClass<T1>
    {
        public void Process<T2>(ref T2 other)
        {
        }

        public void Method1(int a)
        {
        }

        public void Process(int a)
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
