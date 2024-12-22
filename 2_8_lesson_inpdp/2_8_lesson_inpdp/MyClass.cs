namespace _2_8_lesson_inpdp
{
    public class MyClass
    {
      public void MySwap<B>(ref B a, ref B b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
