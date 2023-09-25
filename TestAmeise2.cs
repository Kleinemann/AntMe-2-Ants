using AntMe_2_Lib.Definitions;
using AntMe_2_Lib.GameObject;

namespace AntMe_2_Ants
{
    [Player(ColonyName = "Hercules 2",
        FirstName = "Marcel",
        LastName = "Klein")]
    [Caste(
        Name = "Stark",
        AttackModifier = 1,
        EnergyModifier = 1,
        LoadModifier = -2,
        RangeModifier = 0,
        RotationSpeedModifier = 0,
        SpeedModifier = 0,
        ViewRangeModifier = 0
    ),
    Caste(
        Name = "Späher",
        AttackModifier = -1,
        EnergyModifier = -1,
        LoadModifier = -1,
        RangeModifier = -1,
        RotationSpeedModifier = 0,
        SpeedModifier = 2,
        ViewRangeModifier = 2
        )]
    public class TestAmeise2 : AntCore
    {
        public override string CasteSelect()
        {
            return "Stark";
        }

        public override void Init()
        {
            ShowDebugInfo(" wurde geboren");
        }

        public override void Waiting()
        {
            
        }

        public override void Tick()
        {
            ShowDebugInfo(" tiktak");
        }
    }
}