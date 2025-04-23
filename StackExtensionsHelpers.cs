using System.Collections.Generic;
using Classes_as_the_basis_of_C__Homework;

internal static class StackExtensionsHelpers
{
    public static void Merge(this Stack s1, Stack s2)
    {
        if (s2.Size == 0) return;

        var tempList = new List<string>();
        while (s2.Size > 0)
        {
            tempList.Add(s2.PopfromStack());
        }

        foreach (var item in tempList)
        {
            s1.AddinStask(item);
        }
    }
}