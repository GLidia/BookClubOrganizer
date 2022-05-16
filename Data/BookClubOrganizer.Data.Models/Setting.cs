namespace BookClubOrganizer.Data.Models
{
    using BookClubOrganizer.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
