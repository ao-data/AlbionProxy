﻿namespace AlbionProxy
{
    public enum EventCodes : short
    {
        Leave = 1,
        JoinFinished,
        Move,
        Teleport,
        Unknown5,
        HealthUpdate,
        EnergyUpdate,
        DamageShieldUpdate,
        CraftingFocusUpdate,
        ActiveSpellEffectsUpdate,
        Unknown11,
        Attack,
        CastStart,
        ChannelingUpdate,
        CastCancel,
        CastTimeUpdate,
        CastFinished,
        CastSpell,
        CastHit,
        CastHits,
        ChannelingEnded,
        AttackBuilding,
        InventoryPutItem,
        InventoryDeleteItem,
        NewCharacter,
        NewEquipmentItem,
        NewSimpleItem,
        NewFurnitureItem,
        NewJournalItem,
        NewLaborerItem,
        NewSimpleHarvestableObject,
        NewSimpleHarvestableObjectList,
        NewHarvestableObject,
        NewSilverObject,
        NewBuilding,
        HarvestableChangeState,
        MobChangeState,
        FactionBuildingInfo,
        CraftBuildingInfo,
        RepairBuildingInfo,
        MeldBuildingInfo,
        ConstructionSiteInfo,
        PlayerBuildingInfo,
        FarmBuildingInfo,
        TutorialBuildingInfo,
        LaborerObjectInfo,
        LaborerObjectJobInfo,
        MarketPlaceBuildingInfo,
        HarvestStart,
        HarvestCancel,
        HarvestFinished,
        TakeSilver,
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        ActionOnBuildingFinished,
        ItemRerollQualityStart,
        ItemRerollQualityCancel,
        ItemRerollQualityFinished,
        InstallResourceStart,
        InstallResourceCancel,
        InstallResourceFinished,
        CraftItemFinished,
        LogoutCancel,
        ChatMessage,
        ChatSay,
        ChatWhisper,
        ChatMuted,
        PlayEmote,
        StopEmote,
        SystemMessage,
        UtilityTextMessage,
        UpdateMoney,
        UpdateFame,
        UpdateLearningPoints,
        UpdateReSpecPoints,
        UpdateCurrency,
        UpdateFactionStanding,
        Respawn,
        ServerDebugLog,
        CharacterEquipmentChanged,
        RegenerationHealthChanged,
        RegenerationEnergyChanged,
        RegenerationMountHealthChanged,
        RegenerationCraftingChanged,
        RegenerationHealthEnergyComboChanged,
        RegenerationPlayerComboChanged,
        DurabilityChanged,
        NewLoot,
        AttachItemContainer,
        DetachItemContainer,
        InvalidateItemContainer,
        LockItemContainer,
        GuildUpdate,
        GuildPlayerUpdated,
        InvitedToGuild,
        GuildMemberWorldUpdate,
        UpdateMatchDetails,
        ObjectEvent,
        NewMonolithObject,
        NewSiegeCampObject,
        NewOrbObject,
        NewCastleObject,
        NewSpellEffectArea,
        NewChainSpell,
        Unknown105,
        UpdateChainSpell,
        NewTreasureChest,
        StartMatch,
        StartTerritoryMatchInfos,
        StartArenaMatchInfos,
        EndTerritoryMatch,
        EndArenaMatch,
        MatchUpdate,
        ActiveMatchUpdate,
        NewMob,
        DebugAggroInfo,
        DebugVariablesInfo,
        DebugReputationInfo,
        DebugDiminishingReturnInfo,
        DebugSmartClusterQueueInfo,
        ClaimOrbStart,
        ClaimOrbFinished,
        ClaimOrbCancel,
        OrbUpdate,
        OrbClaimed,
        NewWarCampObject,
        NewMatchLootChestObject,
        NewArenaExit,
        GuildMemberTerritoryUpdate,
        InvitedMercenaryToMatch,
        ClusterInfoUpdate,
        ForcedMovement,
        ForcedMovementCancel,
        CharacterStats,
        CharacterStatsKillHistory,
        CharacterStatsDeathHistory,
        GuildStats,
        KillHistoryDetails,
        FullAchievementInfo,
        FinishedAchievement,
        AchievementProgressInfo,
        FullAchievementProgressInfo,
        FullTrackedAchievementInfo,
        FullAutoLearnAchievementInfo,
        QuestGiverQuestOffered,
        QuestGiverDebugInfo,
        ConsoleEvent,
        TimeSync,
        ChangeAvatar,
        ChangeMountSkin,
        GameEvent,
        KilledPlayer,
        Died,
        KnockedDown,
        MatchPlayerJoinedEvent,
        MatchPlayerStatsEvent,
        MatchPlayerStatsCompleteEvent,
        MatchTimeLineEventEvent,
        MatchPlayerMainGearStatsEvent,
        MatchPlayerChangedAvatarEvent,
        InvitationPlayerTrade,
        Unknown162,
        PlayerTradeCancel,
        PlayerTradeUpdate,
        PlayerTradeFinished,
        PlayerTradeAcceptChange,
        MiniMapPing,
        MarketPlaceNotification,
        DuellingChallengePlayer,
        NewDuellingPost,
        DuelStarted,
        DuelEnded,
        DuelDenied,
        DuelLeftArea,
        Unknown175,
        DuelReEnteredArea,
        NewRealEstate,
        MiniMapOwnedBuildingsPositions,
        Unknown178,
        GuildLogoUpdate,
        Unknown180,
        PlaceableObjectPlace,
        PlaceableObjectPlaceCancel,
        FurnitureObjectBuffProviderInfo,
        FurnitureObjectCheatProviderInfo,
        FarmableObjectInfo,
        NewUnreadMails,
        Unknown187,
        GuildLogoObjectUpdate,
        StartLogout,
        NewChatChannels,
        JoinedChatChannel,
        LeftChatChannel,
        RemovedChatChannel,
        AccessStatus,
        Mounted,
        MountStart,
        MountCancel,
        NewTravelpoint,
        NewIslandAccessPoint,
        NewExit,
        UpdateHome,
        UpdateChatSettings,
        ResurrectionOffer,
        ResurrectionReply,
        LootEquipmentChanged,
        UpdateUnlockedGuildLogos,
        UpdateUnlockedAvatars,
        UpdateUnlockedAvatarRings,
        UpdateUnlockedBuildings,
        NewIslandManagement,
        NewTeleportStone,
        Cloak,
        PartyInvitation,
        PartyJoined,
        PartyDisbanded,
        PartyPlayerJoined,
        PartyChangedOrder,
        PartyPlayerLeft,
        PartyLeaderChanged,
        PartyLootSettingChangedPlayer,
        PartySilverGained,
        PartyPlayerUpdated,
        PartyInvitationPlayerBusy,
        PartyMarkedObjectsUpdated,
        PartyOnClusterPartyJoined,
        PartySetRoleFlag,
        SpellCooldownUpdate,
        NewHellgate,
        NewHellgateExit,
        NewExpeditionExit,
        NewExpeditionNarrator,
        ExitEnterStart,
        ExitEnterCancel,
        ExitEnterFinished,
        HellClusterTimeUpdate,
        NewQuestGiverObject,
        FullQuestInfo,
        QuestProgressInfo,
        QuestGiverInfoForPlayer,
        FullExpeditionInfo,
        ExpeditionQuestProgressInfo,
        InvitedToExpedition,
        ExpeditionRegistrationInfo,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        RewardGranted,
        ArenaRegistrationInfo,
        EnteringArenaStart,
        EnteringArenaCancel,
        EnteringArenaLockStart,
        EnteringArenaLockCancel,
        InvitedToArenaMatch,
        PlayerCounts,
        InCombatStateUpdate,
        Unknown256, // No idea if this is the real placement
        Unknown257,
        Unknown258,
        Unknown259,
        OtherGrabbedLoot,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        SiegeCampClaimFinished,
        SiegeCampScheduleResult,
        TreasureChestUsingStart,
        TreasureChestUsingFinished,
        TreasureChestUsingCancel,
        TreasureChestUsingOpeningComplete,
        TreasureChestForceCloseInventory,
        PremiumChanged,
        PremiumExtended,
        PremiumLifeTimeRewardGained,
        LaborerGotUpgraded,
        JournalGotFull,
        JournalFillError,
        FriendRequest,
        FriendRequestInfos,
        FriendInfos,
        FriendRequestAnswered,
        Unknown279,
        FriendOnlineStatus, // Should be down by partyloot items
        FriendRequestCanceled,
        FriendRemoved,
        FriendUpdated,
        PartyLootItems,
        PartyLootItemsRemoved,
        ReputationUpdate,
        DefenseUnitAttackBegin,
        DefenseUnitAttackEnd,
        DefenseUnitAttackDamage,
        UnrestrictedPvpZoneUpdate,
        ReputationImplicationUpdate,
        NewMountObject,
        MountHealthUpdate,
        MountCooldownUpdate,
        NewExpeditionAgent,
        NewExpeditionCheckPoint,
        Unknown292,
        VoteEvent,
        RatingEvent,
        NewArenaAgent,
        BoostFarmable,
        NewPortalEntrance,
        NewPortalExit,
        NewRandomDungeonExit,
        WaitingQueueUpdate,
        PlayerMovementRateUpdate,
        ObserveStart,
        MinimapZergs,
        MinimapSmartClusterZergs,
        PaymentTransactions,
        PerformanceStatsUpdate,
        OverloadModeUpdate,
        DebugDrawEvent,
        RecordCameraMove,
        RecordStart,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        TerritoryClaimFinished,
        TerritoryScheduleResult,
        UpdateAccountState,
        StartDeterministicRoam,
        GuildFullAccessTagsUpdated,
        GuildAccessTagUpdated,
        GvgSeasonUpdate,
        GvgSeasonCheatCommand,
        SeasonPointsByKillingBooster,
        FishingStart,
        FishingCast,
        FishingCatch,
        FishingFinished,
        FishingCancel,
        NewFloatObject,
        NewFishingZoneObject,
        FishingMiniGame,
        SteamAchievementCompleted,
        UpdatePuppet,
        ChangeFlaggingFinished,
        NewOutpostObject,
        OutpostUpdate,
        OutpostClaimed,
        OutpostReward,
        OverChargeEnd,
        OverChargeStatus,
        PartyFinderFullUpdate,
        PartyFinderUpdate,
        PartyFinderApplicantsUpdate,
        PartyFinderEquipmentSnapshot,
        PartyFinderJoinRequestDeclined,
        NewUnlockedPersonalSeasonRewards,
        PersonalSeasonPointsGained,
        EasyAntiCheatMessageToClient,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningFinished,
        MatchLootChestOpeningCancel,
        NotifyCrystalMatchReward,
        CrystalRealmFeedback,
        NewLocationMarker,
        NewTutorialBlocker,
        NewTileSwitch,
        NewInformationProvider,
        NewDynamicGuildLogo,
        TutorialUpdate,
        TriggerHintBox,
        RandomDungeonPositionInfo,
        NewLootChest,
        UpdateLootChest,
        LootChestOpened,
        NewShrine,
        UpdateShrine,
        MutePlayerUpdate,
        ShopTileUpdate,
        ShopUpdate,
        EasyAntiCheatKick,
        UnlockVanityUnlock,
        AvatarUnlocked,
        CustomizationChanged,
        BaseVaultInfo,
        GuildVaultInfo,
        BankVaultInfo,
        RecoveryVaultPlayerInfo,
        RecoveryVaultGuildInfo,
        UpdateWardrobe,
        CastlePhaseChanged,
        GuildAccountLogEvent,
        NewHideoutObject,
        NewHideoutManagement,
        NewHideoutExit,
        InitHideoutAttackStart,
        InitHideoutAttackCancel,
        InitHideoutAttackFinished,
        HideoutManagementUpdate,
        IpChanged,
        SmartClusterQueueUpdateInfo,
        SmartClusterQueueActiveInfo,
        SmartClusterQueueKickWarning,
        SmartClusterQueueInvite,
        ReceivedGvgSeasonPoints,
        TerritoryBonusLevelUpdate,
        OpenWorldAttackScheduleStart,
        OpenWorldAttackScheduleFinished,
        OpenWorldAttackScheduleCancel,
        OpenWorldAttackConquerStart,
        OpenWorldAttackConquerFinished,
        OpenWorldAttackConquerCancel,
        OpenWorldAttackConquerStatus,
        OpenWorldAttackStart,
        OpenWorldAttackEnd,
        NewRandomResourceBlocker,
        NewHomeObject,
        HideoutObjectUpdate,
        UpdateInfamy,
        Unknown413,
        Unknown414,
        Unknown415,
        Unknown416,
        Unknown417,
        NewTunnel = 418,
    }
}
