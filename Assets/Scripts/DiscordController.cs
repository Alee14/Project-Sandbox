using UnityEngine;

public class DiscordController : MonoBehaviour
{

    public Discord.Discord discord;
    public long ApplicationID;
    public string RpcStatus;
    public string RpcDetails;
    public string RpcLargeImage;
    public string RpcLargeImageText;

    // Use this for initialization
    void Start () {
        System.Environment.SetEnvironmentVariable("DISCORD_INSTANCE_ID", "0");
        discord = new Discord.Discord(ApplicationID, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = RpcStatus,
            Details = RpcDetails,
            Assets =
            {
                LargeImage = RpcLargeImage,
                LargeText = RpcLargeImageText
            }
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
            {
                Debug.LogWarning("Everything is fine!");
            }
        });
        
        activityManager.ClearActivity((result) =>
        {
            if (result == Discord.Result.Ok)
            {
                Debug.Log("Success!");
            }
            else
            {
                Debug.LogError("Failed");
            }
        });
    }
	
    // Update is called once per frame
    void Update () {
        discord.RunCallbacks();
    }
}
