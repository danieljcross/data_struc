// WeddingInvite.cs
using System.Collections.Generic;

class WeddingInvite{
    public static HashSet<string> CreateUniqueInviteList(List<string> list1, List<string> list2){

        HashSet<string> uniqueInviteSet = new HashSet<string>(list1);
        uniqueInviteSet.UnionWith(list2);
        return uniqueInviteSet;

    }
}
