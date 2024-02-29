using Ordering.Domain.Common;

namespace Ordering.Domain.Enums
{
    /// <remarks> 
    /// Card type class should be marked as abstract with protected constructor to encapsulate known enum types
    /// this is currently not possible as OrderingContextSeed uses this constructor to load cardTypes from csv file
    /// </remarks>
    public class CardType(int id, string name) : Enumeration(id, name)
    {
        public static CardType Amex = new(1, nameof(Amex));
        public static CardType Visa = new(2, nameof(Visa));
        public static CardType MasterCard = new(3, nameof(MasterCard));
    }
}
