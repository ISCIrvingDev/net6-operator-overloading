namespace Operators
{
    public class ListOperators<T> : List<T>
    {
        public static ListOperators<T> operator +(ListOperators<T> list1, ListOperators<T> list2)
        {
            var result = new ListOperators<T>();

            list1.ForEach(e => result.Add(e));
            list2.ForEach(e => result.Add(e));

            return result;
        }
    }
}