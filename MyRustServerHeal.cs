using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("MyRustServerHeal", "LosGranada", "1.0.0")]
    class MyRustServerHeal : CovalencePlugin
    {
        [Command("mrsheal")]
        private void HealAndFeedPlayerCommand(IPlayer player, string command, string[] args)
        {
            if (args.Length != 1)
            {
                player.Reply("Usage: mrsheal <SteamID>");
                return;
            }

            IPlayer targetPlayer = players.FindPlayer(args[0]);
            if (targetPlayer == null || !targetPlayer.IsConnected)
            {
                player.Reply("Player not found.");
                return;
            }

            BasePlayer bp = targetPlayer.Object as BasePlayer;
            if (bp != null)
            {
                bp.Heal(bp.MaxHealth());
                bp.metabolism.hydration.value = bp.metabolism.hydration.max;
                bp.metabolism.calories.value = bp.metabolism.calories.max;
				bp.metabolism.bleeding.value = 0;
				bp.metabolism.radiation_poison.value = 0;
				bp.metabolism.radiation_level.value = 0;
				bp.metabolism.poison.value = 0;
				bp.metabolism.oxygen.value = 1;
				bp.metabolism.temperature.value = 32;
				bp.metabolism.wetness.value = 0;
				
				
				
                bp.SendNetworkUpdate();
            }

            player.Reply($"{targetPlayer.Name} has been healed.");
        }
    }
}
 