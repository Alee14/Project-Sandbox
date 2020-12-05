using UnityEngine;

public class DiscordController : MonoBehaviour
{

    public Discord.Discord discord;

    // Use this for initialization
    void Start () {
        System.Environment.SetEnvironmentVariable("DISCORD_INSTANCE_ID", "0");
        discord = new Discord.Discord(784835227338932244, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = "In Development...",
            Details = "An upcoming Unity game by Alee!",
            Assets =
            {
                LargeImage = "wip",
                LargeText = "Work in Progress!"
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
