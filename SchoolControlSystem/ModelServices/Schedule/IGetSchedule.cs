using SchoolControlSystem.Model;

namespace SchoolControlSystem.ModelServices
{
    public interface IGetSchedule
    {        
        Schedule GetSchedule(string code);
    }
}
