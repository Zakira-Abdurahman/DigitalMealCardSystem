using System.ComponentModel;

namespace DigitalMealCardSystem
{
    public enum MealType
    {

        [Description("Break Fast")]
        Breakfast = 1,
        [Description("Lunch")]
        Lunch = 2,
        [Description(" Dinner")]
        Dinner = 3
    }
    public enum RecordStatus
    {
        Active = 1, Inactive, Deleted
    }

}
