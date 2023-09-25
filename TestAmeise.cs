using AntMe_2_Lib.Definitions;
using AntMe_2_Lib.GameObject;

namespace AntMe_2_Ants
{
    [Player(ColonyName="Testameisen",
        FirstName = "Marcel",
        LastName = "Klein")]
    [Caste(
        Name = "Test",
        AttackModifier = 0,
        EnergyModifier = 0,
        LoadModifier = 0,
        RangeModifier = 0,
        RotationSpeedModifier = 0,
        SpeedModifier = 0,
        ViewRangeModifier = 0
    ),
    Caste(
        Name = "Schnell",
        AttackModifier = -1,
        EnergyModifier = -1,
        LoadModifier = -1,
        RangeModifier = -1,
        RotationSpeedModifier = -1,
        SpeedModifier = 6,
        ViewRangeModifier = -1
        )]
    public class TestAmeise : AntCore
    {
        static string lastCaste = string.Empty;

        public override string CasteSelect()
        {
            string caste = lastCaste == "Test" ? "Schnell" : "Test";
            lastCaste = caste;
            return caste;
        }

        public override void Init()
        {
            ShowDebugInfo(" erwacht zum Leben");
        }

        public override void Waiting()
        {
            ShowDebugInfo("wartet");
        }

        public override void Tick()
        {
            ShowDebugInfo("Tick");
        }
    }
}