using DotNetEnv;
namespace Conf.Settings;


public class Settings
{
    public Settings()
    {
        Env.Load();

        var anpPeg = Env.GetString("ANP_PEG");
        var anpRoyalties = Env.GetString("ANP_ROYALTIES");

    }




}