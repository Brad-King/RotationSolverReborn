﻿
using XIVAutoAttack.Actions.BaseAction;
using XIVAutoAttack.Helpers;
using static XIVAutoAttack.Combos.Basic.RPRCombo_Base<TCmd>;

namespace XIVAutoAttack.Data
{
    internal enum ActionID : uint
    {
        #region Astrologian

        /// <summary>
        /// 生辰
        /// </summary>
        Ascend = 3603,

        /// <summary>
        /// 凶星
        /// </summary>
        Malefic = 3596,

        /// <summary>
        /// 烧灼
        /// </summary>
        Combust = 3599,

        /// <summary>
        /// 重力
        /// </summary>
        Gravity = 3615,

        /// <summary>
        /// 吉星
        /// </summary>
        Benefic = 3594,

        /// <summary>
        /// 福星
        /// </summary>
        Benefic2 = 3610,

        /// <summary>
        /// 吉星相位
        /// </summary>
        AspectedBenefic = 3595,

        /// <summary>
        /// 先天禀赋
        /// </summary>
        EssentialDignity = 3614,

        /// <summary>
        /// 星位合图
        /// </summary>
        Synastry = 3612,

        /// <summary>
        /// 天星交错
        /// </summary>
        CelestialIntersection = 16556,

        /// <summary>
        /// 擢升
        /// </summary>
        Exaltation = 25873,

        /// <summary>
        /// 阳星
        /// </summary>
        Helios = 3600,

        /// <summary>
        /// 阳星相位
        /// </summary>
        AspectedHelios = 3601,

        /// <summary>
        /// 天星冲日
        /// </summary>
        CelestialOpposition = 16553,

        /// <summary>
        /// 地星
        /// </summary>
        EarthlyStar = 7439,

        /// <summary>
        /// 命运之轮
        /// </summary>
        CollectiveUnconscious = 3613,

        /// <summary>
        /// 天宫图
        /// </summary>
        Horoscope = 16557,

        /// <summary>
        /// 光速
        /// </summary>
        Lightspeed = 3606,

        /// <summary>
        /// 中间学派
        /// </summary>
        NeutralSect = 16559,

        /// <summary>
        /// 大宇宙
        /// </summary>
        Macrocosmos = 25874,

        /// <summary>
        /// 星力
        /// </summary>
        Astrodyne = 25870,

        /// <summary>
        /// 占卜
        /// </summary>
        Divination = 16552,

        /// <summary>
        /// 抽卡
        /// </summary>
        Draw = 3590,

        /// <summary>
        /// 重抽
        /// </summary>
        Redraw = 3593,

        /// <summary>
        /// 小奥秘卡
        /// </summary>
        MinorArcana = 7443,

        /// <summary>
        /// 出王冠卡
        /// </summary>
        CrownPlay = 25869,

        /// <summary>
        /// 太阳神之衡
        /// </summary>
        Balance = 4401,

        /// <summary>
        /// 放浪神之箭
        /// </summary>
        Arrow = 4402,

        /// <summary>
        /// 战争神之枪
        /// </summary>
        Spear = 4403,

        /// <summary>
        /// 世界树之干
        /// </summary>
        Bole = 4404,

        /// <summary>
        /// 河流神之瓶
        /// </summary>
        Ewer = 4405,

        /// <summary>
        /// 建筑神之塔
        /// </summary>
        Spire = 4406,
        #endregion

        #region BlackMage
        /// <summary>
        /// 闪雷
        /// </summary>
        Thunder = 144,

        /// <summary>
        /// 震雷
        /// </summary>
        Thunder2 = 7447,

        /// <summary>
        /// 暴雷
        /// </summary>
        Thunder3 = 153,

        /// <summary>
        /// 星灵移位
        /// </summary>
        Transpose = 149,

        /// <summary>
        /// 灵极魂
        /// </summary>
        UmbralSoul = 16506,

        /// <summary>
        /// 魔罩
        /// </summary>
        Manaward = 157,

        /// <summary>
        /// 魔泉
        /// </summary>
        Manafont = 158,

        /// <summary>
        /// 激情咏唱
        /// </summary>
        Sharpcast = 3574,

        /// <summary>
        /// 三连咏唱
        /// </summary>
        Triplecast = 7421,

        /// <summary>
        /// 黑魔纹
        /// </summary>
        Leylines = 3573,

        /// <summary>
        /// 魔纹步
        /// </summary>
        BetweenTheLines = 7419,

        /// <summary>
        /// 以太步
        /// </summary>
        AetherialManipulation = 155,

        /// <summary>
        /// 详述
        /// </summary>
        Amplifier = 25796,

        /// <summary>
        /// 核爆
        /// </summary>
        Flare = 162,

        /// <summary>
        /// 绝望
        /// </summary>
        Despair = 16505,

        /// <summary>
        /// 秽浊
        /// </summary>
        Foul = 7422,

        /// <summary>
        /// 异言
        /// </summary>
        Xenoglossy = 16507,

        /// <summary>
        /// 崩溃
        /// </summary>
        Scathe = 156,

        /// <summary>
        /// 悖论
        /// </summary>
        Paradox = 25797,

        /// <summary>
        /// 火炎
        /// </summary>
        Fire = 141,

        /// <summary>
        /// 烈炎
        /// </summary>
        Fire2 = 147,

        /// <summary>
        /// 爆炎
        /// </summary>
        Fire3 = 152,

        /// <summary>
        /// 炽炎
        /// </summary>
        Fire4 = 3577,

        /// <summary>
        /// 冰结
        /// </summary>
        Blizzard = 142,

        /// <summary>
        /// 冰冻
        /// </summary>
        Blizzard2 = 25793,

        /// <summary>
        /// 冰封
        /// </summary>
        Blizzard3 = 154,

        /// <summary>
        /// 冰澈
        /// </summary>
        Blizzard4 = 3576,

        /// <summary>
        /// 冻结
        /// </summary>
        Freeze = 159,
        #endregion

        #region BlueMage
        /// <summary>
        /// 水炮
        /// </summary>
        WaterCannon = 11385,
        #endregion

        #region Bard
        /// <summary>
        /// 强力射击
        /// </summary>
        HeavyShoot = 97,

        /// <summary>
        /// 直线射击
        /// </summary>
        StraitShoot = 98,

        /// <summary>
        /// 毒咬箭
        /// </summary>
        VenomousBite = 100,

        /// <summary>
        /// 风蚀箭
        /// </summary>
        Windbite = 113,

        /// <summary>
        /// 伶牙俐齿
        /// </summary>
        IronJaws = 3560,

        /// <summary>
        /// 贤者的叙事谣
        /// </summary>
        MagesBallad = 114,

        /// <summary>
        /// 军神的赞美歌
        /// </summary>
        ArmysPaeon = 116,

        /// <summary>
        /// 放浪神的小步舞曲
        /// </summary>
        WanderersMinuet = 3559,

        /// <summary>
        /// 战斗之声
        /// </summary>
        BattleVoice = 118,

        /// <summary>
        /// 猛者强击
        /// </summary>
        RagingStrikes = 101,

        /// <summary>
        /// 光明神的最终乐章
        /// </summary>
        RadiantFinale = 25785,

        /// <summary>
        /// 纷乱箭
        /// </summary>
        Barrage = 107,

        /// <summary>
        /// 九天连箭
        /// </summary>
        EmpyrealArrow = 3558,

        /// <summary>
        /// 完美音调
        /// </summary>
        PitchPerfect = 7404,

        /// <summary>
        /// 失血箭
        /// </summary>
        Bloodletter = 110,

        /// <summary>
        /// 死亡箭雨
        /// </summary>
        RainofDeath = 117,

        /// <summary>
        /// 连珠箭
        /// </summary>
        QuickNock = 106,

        /// <summary>
        /// 影噬箭
        /// </summary>
        Shadowbite = 16494,

        /// <summary>
        /// 光阴神的礼赞凯歌
        /// </summary>
        WardensPaean = 3561,

        /// <summary>
        /// 大地神的抒情恋歌
        /// </summary>
        NaturesMinne = 7408,

        /// <summary>
        /// 侧风诱导箭
        /// </summary>
        Sidewinder = 3562,

        /// <summary>
        /// 绝峰箭
        /// </summary>
        ApexArrow = 16496,

        /// <summary>
        /// 行吟
        /// </summary>
        Troubadour = 7405,
        #endregion

        #region Dancer
        /// <summary>
        /// 瀑泻
        /// </summary>
        Cascade = 15989,

        /// <summary>
        /// 喷泉
        /// </summary>
        Fountain = 15990,

        /// <summary>
        /// 逆瀑泻
        /// </summary>
        ReverseCascade = 15991,

        /// <summary>
        /// 坠喷泉
        /// </summary>
        Fountainfall = 15992,

        /// <summary>
        /// 扇舞·序
        /// </summary>
        FanDance = 16007,

        /// <summary>
        /// 风车
        /// </summary>
        Windmill = 15993,

        /// <summary>
        /// 落刃雨
        /// </summary>
        Bladeshower = 15994,

        /// <summary>
        /// 升风车
        /// </summary>
        RisingWindmill = 15995,

        /// <summary>
        /// 落血雨
        /// </summary>
        Bloodshower = 15996,

        /// <summary>
        /// 扇舞·破
        /// </summary>
        FanDance2 = 16008,

        /// <summary>
        /// 扇舞·急
        /// </summary>
        FanDance3 = 16009,

        /// <summary>
        /// 扇舞·终
        /// </summary>
        FanDance4 = 25791,

        /// <summary>
        /// 剑舞
        /// </summary>
        SaberDance = 16005,

        /// <summary>
        /// 流星舞
        /// </summary>
        StarfallDance = 25792,

        /// <summary>
        /// 前冲步
        /// </summary>
        EnAvant = 16010,

        /// <summary>
        /// 蔷薇曲脚步
        /// </summary>
        Emboite = 15999,

        /// <summary>
        /// 小鸟交叠跳
        /// </summary>
        Entrechat = 16000,

        /// <summary>
        /// 绿叶小踢腿
        /// </summary>
        Jete = 16001,

        /// <summary>
        /// 金冠趾尖转
        /// </summary>
        Pirouette = 16002,

        /// <summary>
        /// 标准舞步
        /// </summary>
        StandardStep = 15997,

        /// <summary>
        /// 技巧舞步
        /// </summary>
        TechnicalStep = 15998,

        /// <summary>
        /// 防守之桑巴
        /// </summary>
        ShieldSamba = 16012,

        /// <summary>
        /// 治疗之华尔兹
        /// </summary>
        CuringWaltz = 16015,

        /// <summary>
        /// 闭式舞姿
        /// </summary>
        ClosedPosition = 16006,

        /// <summary>
        /// 进攻之探戈
        /// </summary>
        Devilment = 16011,

        /// <summary>
        /// 百花争艳
        /// </summary>
        Flourish = 16013,

        /// <summary>
        /// 即兴表演
        /// </summary>
        Improvisation = 16014,

        /// <summary>
        /// 提拉纳
        /// </summary>
        Tillana = 25790,
        #endregion

        #region Dragoon
        /// <summary>
        /// 精准刺
        /// </summary>
        TrueThrust = 75,

        /// <summary>
        /// 贯通刺
        /// </summary>
        VorpalThrust = 78,

        /// <summary>
        /// 龙眼雷电
        /// </summary>
        RaidenThrust = 16479,

        /// <summary>
        /// 直刺
        /// </summary>
        FullThrust = 84,

        /// <summary>
        /// 苍穹刺
        /// </summary>
        HeavensThrust = 25771,

        /// <summary>
        /// 开膛枪
        /// </summary>
        Disembowel = 87,

        /// <summary>
        /// 樱花怒放
        /// </summary>
        ChaosThrust = 88,

        /// <summary>
        /// 樱花怒放
        /// </summary>
        ChaoticSpring = 25772,

        /// <summary>
        /// 龙尾大回旋
        /// </summary>
        WheelingThrust = 3556,

        /// <summary>
        /// 龙牙龙爪
        /// </summary>
        FangandClaw = 3554,

        /// <summary>
        /// 贯穿尖
        /// </summary>
        PiercingTalon = 90,

        /// <summary>
        /// 死天枪
        /// </summary>
        DoomSpike = 86,

        /// <summary>
        /// 音速刺
        /// </summary>
        SonicThrust = 7397,

        /// <summary>
        /// 龙眼苍穹
        /// </summary>
        DraconianFury = 25770,

        /// <summary>
        /// 山境酷刑
        /// </summary>
        CoerthanTorment = 16477,

        /// <summary>
        /// 破碎冲
        /// </summary>
        SpineshatterDive = 95,

        /// <summary>
        /// 龙炎冲
        /// </summary>
        DragonfireDive = 96,

        /// <summary>
        /// 跳跃
        /// </summary>
        Jump = 92,

        /// <summary>
        /// 高跳
        /// </summary>
        HighJump = 16478,

        /// <summary>
        /// 幻象冲
        /// </summary>
        MirageDive = 7399,

        /// <summary>
        /// 武神枪
        /// </summary>
        Geirskogul = 3555,

        /// <summary>
        /// 死者之岸
        /// </summary>
        Nastrond = 7400,

        /// <summary>
        /// 坠星冲
        /// </summary>
        Stardiver = 16480,

        /// <summary>
        /// 天龙点睛
        /// </summary>
        WyrmwindThrust = 25773,
        #endregion

        #region DRK
        /// <summary>
        /// 重斩
        /// </summary>
        HardSlash = 3617,
        /// <summary>
        /// 吸收斩
        /// </summary>
        SyphonStrike = 3623,
        /// <summary>
        /// 释放
        /// </summary>
        Unleash = 3621,
        /// <summary>
        /// 深恶痛绝
        /// </summary>
        Grit = 3629,
        /// <summary>
        /// 伤残
        /// </summary>
        Unmend = 3624,     
        /// <summary>
        /// 噬魂斩
        /// </summary>
        Souleater = 3632,
        /// <summary>
        /// 暗黑波动
        /// </summary>
        FloodofDarkness = 16466,
        /// <summary>
        /// 暗黑锋
        /// </summary>
        EdgeofDarkness = 16467,      
        /// <summary>
        /// 嗜血
        /// </summary>
        BloodWeapon = 3625,       
        /// <summary>
        /// 暗影墙
        /// </summary>
        ShadowWall = 3636,      
        /// <summary>
        /// 弃明投暗
        /// </summary>
        DarkMind = 3634,       
        /// <summary>
        /// 行尸走肉
        /// </summary>
        LivingDead = 3638,      
        /// <summary>
        /// 腐秽大地
        /// </summary>
        SaltedEarth = 3639,
        /// <summary>
        /// 跳斩
        /// </summary>
        Plunge = 3640,       

        /// <summary>
        /// 吸血深渊
        /// </summary>
        AbyssalDrain = 3641,
        /// <summary>
        /// 精雕怒斩
        /// </summary>
        CarveandSpit = 3643,
        /// <summary>
        /// 血溅
        /// </summary>
        Bloodspiller = 7392,       

        /// <summary>
        /// 寂灭
        /// </summary>
        Quietus = 7391,
        /// <summary>
        /// 血乱
        /// </summary>
        Delirium = 7390,       

        /// <summary>
        /// 至黑之夜
        /// </summary>
        TheBlackestNight = 7393,     
        /// <summary>
        /// 刚魂
        /// </summary>
        StalwartSoul = 16468,
        /// <summary>
        /// 暗黑布道
        /// </summary>
        DarkMissionary = 16471,
        /// <summary>
        /// 掠影示现
        /// </summary>
        LivingShadow = 16472,       
        /// <summary>
        /// 献奉
        /// </summary>
        Oblation = 25754,       

        /// <summary>
        /// 龙剑
        /// </summary>
        LifeSurge = 83,

        /// <summary>
        /// 猛枪
        /// </summary>
        LanceCharge = 85,

        /// <summary>
        /// 巨龙视线
        /// </summary>
        DragonSight = 7398,

        /// <summary>
        /// 战斗连祷
        /// </summary>
        BattleLitany = 3557,
        /// <summary>
        /// 暗影使者
        /// </summary>
        Shadowbringer = 25757,     
        /// <summary>
        /// 腐秽黑暗
        /// </summary>
        SaltandDarkness = 25755,        
        #endregion

        #region GNB
        /// <summary>
        /// 王室亲卫
        /// </summary>
        RoyalGuard = 16142,
        /// <summary>
        /// 利刃斩
        /// </summary>
        KeenEdge = 16137,
        /// <summary>
        /// 无情
        /// </summary>
        NoMercy = 16138,
        /// <summary>
        /// 残暴弹
        /// </summary>
        BrutalShell = 16139,
        /// <summary>
        /// 伪装
        /// </summary>
        Camouflage = 16140,       
        /// <summary>
        /// 恶魔切
        /// </summary>
        DemonSlice = 16141,
        /// <summary>
        /// 闪雷弹
        /// </summary>
        LightningShot = 16143,
        /// <summary>
        /// 危险领域
        /// </summary>
        DangerZone = 16144,
        /// <summary>
        /// 迅连斩
        /// </summary>
        SolidBarrel = 16145,
        /// <summary>
        /// 爆发击
        /// </summary>
        BurstStrike = 16162,   
        /// <summary>
        /// 星云
        /// </summary>
        Nebula = 16148,      
        /// <summary>
        /// 恶魔杀
        /// </summary>
        DemonSlaughter = 16149,
        /// <summary>
        /// 极光
        /// </summary>
        Aurora = 16151,

        /// <summary>
        /// 超火流星
        /// </summary>
        Superbolide = 16152,     
        /// <summary>
        /// 音速破
        /// </summary>
        SonicBreak = 16153,
        /// <summary>
        /// 粗分斩
        /// </summary>
        RoughDivide = 16154,    
        /// <summary>
        /// 烈牙
        /// </summary>
        GnashingFang = 16146,     
        /// <summary>
        /// 弓形冲波
        /// </summary>
        BowShock = 16159,
        /// <summary>
        /// 光之心
        /// </summary>
        HeartofLight = 16160,
        /// <summary>
        /// 石之心
        /// </summary>
        HeartofStone = 16161,     

        /// <summary>
        /// 命运之环
        /// </summary>
        FatedCircle = 16163,    
        /// <summary>
        /// 血壤
        /// </summary>
        Bloodfest = 16164,
        /// <summary>
        /// 倍攻
        /// </summary>
        DoubleDown = 25760,
        /// <summary>
        /// 猛兽爪
        /// </summary>
        SavageClaw = 16147,    
        /// <summary>
        /// 凶禽爪
        /// </summary>
        WickedTalon = 16150,    
        /// <summary>
        /// 撕喉
        /// </summary>
        JugularRip = 16156,     
        /// <summary>
        /// 裂膛
        /// </summary>
        AbdomenTear = 16157,     
        /// <summary>
        /// 穿目
        /// </summary>
        EyeGouge = 16158,      
        /// <summary>
        /// 超高速
        /// </summary>
        Hypervelocity = 25759,        
        #endregion

        #region MCH
        /// <summary>
        /// 分裂弹
        /// </summary>
        SplitShot = 2866,
        /// <summary>
        /// 独头弹
        /// </summary>
        SlugShot = 2868,        

        /// <summary>
        /// 狙击弹
        /// </summary>
        CleanShot = 2873,       

        /// <summary>
        /// 热冲击
        /// </summary>
        HeatBlast = 7410,
        /// <summary>
        /// 散射
        /// </summary>
        SpreadShot = 2870,
        /// <summary>
        /// 自动弩
        /// </summary>
        AutoCrossbow = 16497,
        /// <summary>
        /// 热弹
        /// </summary>
        HotShot = 2872,
        /// <summary>
        /// 空气锚
        /// </summary>
        AirAnchor = 16500,
        /// <summary>
        /// 钻头
        /// </summary>
        Drill = 16498,
        /// <summary>
        /// 回转飞锯
        /// </summary>
        ChainSaw = 25788,
        /// <summary>
        /// 毒菌冲击
        /// </summary>
        Bioblaster = 16499,
        /// <summary>
        /// 整备
        /// </summary>
        Reassemble = 2876,       

        /// <summary>
        /// 超荷
        /// </summary>
        Hypercharge = 17209,      
        /// <summary>
        /// 野火
        /// </summary>
        Wildfire = 2878,        

        /// <summary>
        /// 虹吸弹
        /// </summary>
        GaussRound = 2874,
        /// <summary>
        /// 弹射
        /// </summary>
        Ricochet = 2890,        
        /// <summary>
        /// 枪管加热
        /// </summary>
        BarrelStabilizer = 7414,   
        /// <summary>
        /// 车式浮空炮塔
        /// </summary>
        RookAutoturret = 2864,    
        /// <summary>
        /// 策动
        /// </summary>
        Tactician = 16889,        
        #endregion

        #region MNK
        //双龙脚
        DragonKick = 74,  
        
        /// <summary>
        /// 连击
        /// </summary>
        Bootshine = 53,

        /// <summary>
        /// 破坏神冲 aoe
        /// </summary>
        ArmoftheDestroyer = 62,

        /// <summary>
        /// 双掌打 伤害提高
        /// </summary>
        TwinSnakes = 61,

        /// <summary>
        /// 正拳
        /// </summary>
        TrueStrike = 54,

        /// <summary>
        /// 四面脚 aoe
        /// </summary>
        FourpointFury = 16473,

        /// <summary>
        /// 破碎拳
        /// </summary>
        Demolish = 66,  
        
        /// <summary>
        /// 崩拳
        /// </summary>
        SnapPunch = 56,

        /// <summary>
        /// 地烈劲 aoe
        /// </summary>
        Rockbreaker = 70,

        /// <summary>
        /// 斗气
        /// </summary>
        Meditation = 3546,

        /// <summary>
        /// 铁山靠
        /// </summary>
        SteelPeak = 25761, 
        
        /// <summary>
        /// 空鸣拳
        /// </summary>
        HowlingFist = 25763,
        
        /// <summary>
        /// 义结金兰
        /// </summary>
        Brotherhood = 7396,

        /// <summary>
        /// 红莲极意 提高dps
        /// </summary>
        RiddleofFire = 7395,

        /// <summary>
        /// 突进技能
        /// </summary>
        Thunderclap = 25762, 
        
        /// <summary>
        /// 真言
        /// </summary>
        Mantra = 65,

        /// <summary>
        /// 震脚
        /// </summary>
        PerfectBalance = 69,
        
        /// <summary>
        /// 苍气炮 阴
        /// </summary>
        ElixirField = 3545,

        /// <summary>
        /// 爆裂脚 阳
        /// </summary>
        FlintStrike = 25882,

        /// <summary>
        /// 凤凰舞
        /// </summary>
        RisingPhoenix = 25768,

        /// <summary>
        /// 斗魂旋风脚 阴阳
        /// </summary>
        TornadoKick = 3543,

        /// <summary>
        /// 梦幻斗舞
        /// </summary>
        PhantomRush = 25769,

        /// <summary>
        /// 演武
        /// </summary>
        FormShift = 4262,  
        
        /// <summary>
        /// 金刚极意 盾
        /// </summary>
        RiddleofEarth = 7394,   
        
        /// <summary>
        /// 疾风极意
        /// </summary>
        RiddleofWind = 25766,        
        #endregion

        #region NIN
        /// <summary>
        /// 隐遁
        /// </summary>
        Hide = 2245,
        /// <summary>
        /// 双刃旋
        /// </summary>
        SpinningEdge = 2240,
        //残影
        ShadeShift = 2241,
        /// <summary>
        /// 绝风
        /// </summary>
        GustSlash = 2242,
        /// <summary>
        /// 飞刀
        /// </summary>
        ThrowingDagger = 2247,
        /// <summary>
        /// 夺取
        /// </summary>
        Mug = 2248,      
        /// <summary>
        /// 攻其不备
        /// </summary>
        TrickAttack = 2258,   
        /// <summary>
        /// 旋风刃
        /// </summary>
        AeolianEdge = 2255,
        /// <summary>
        /// 血雨飞花
        /// </summary>
        DeathBlossom = 2254,
        /// <summary>
        /// 天之印
        /// </summary>
        Ten = 2259,
        /// <summary>
        /// 地之印
        /// </summary>
        Chi = 2261,
        /// <summary>
        /// 人之印
        /// </summary>
        Jin = 2263,
        /// <summary>
        /// 天地人
        /// </summary>
        TenChiJin = 7403,        
        /// <summary>
        /// 缩地
        /// </summary>
        Shukuchi = 2262,
        /// <summary>
        /// 断绝
        /// </summary>
        Assassinate = 2246,
        /// <summary>
        /// 命水
        /// </summary>
        Meisui = 16489,        
        /// <summary>
        /// 生杀予夺
        /// </summary>
        Kassatsu = 2264,       
        /// <summary>
        /// 八卦无刃杀
        /// </summary>
        HakkeMujinsatsu = 16488,
        /// <summary>
        /// 强甲破点突
        /// </summary>
        ArmorCrush = 3563,       
        /// <summary>
        /// 通灵之术·大虾蟆
        /// </summary>
        HellfrogMedium = 7401,
        /// <summary>
        /// 六道轮回
        /// </summary>
        Bhavacakra = 7402,
        /// <summary>
        /// 分身之术
        /// </summary>
        Bunshin = 16493,
        /// <summary>
        /// 残影镰鼬
        /// </summary>
        PhantomKamaitachi = 25774,     
        /// <summary>
        /// 月影雷兽牙
        /// </summary>
        FleetingRaiju = 25778,       
        /// <summary>
        /// 月影雷兽爪
        /// </summary>
        ForkedRaiju = 25777,       
        /// <summary>
        /// 风来刃
        /// </summary>
        Huraijin = 25876,       
        /// <summary>
        /// 梦幻三段
        /// </summary>
        DreamWithinaDream = 3566,
        /// <summary>
        /// 风魔手里剑天
        /// </summary>
        FumaShurikenTen = 18873,
        /// <summary>
        /// 风魔手里剑人
        /// </summary>
        FumaShurikenJin = 18875,
        /// <summary>
        /// 火遁之术天
        /// </summary>
        KatonTen = 18876,
        /// <summary>
        /// 雷遁之术地
        /// </summary>
        RaitonChi = 18877,
        /// <summary>
        /// 土遁之术地
        /// </summary>
        DotonChi = 18880,
        /// <summary>
        /// 水遁之术人
        /// </summary>
        SuitonJin = 18881,
        /// <summary>
        /// 通灵之术
        /// </summary>
        RabbitMedium = 2272,
        /// <summary>
        /// 风魔手里剑
        /// </summary>
        FumaShuriken = 2265,
        /// <summary>
        /// 火遁之术
        /// </summary>
        Katon = 2266,
        /// <summary>
        /// 雷遁之术
        /// </summary>
        Raiton = 2267,
        /// <summary>
        /// 冰遁之术
        /// </summary>
        Hyoton = 2268,
        /// <summary>
        /// 风遁之术
        /// </summary>
        Huton = 2269,      
        /// <summary>
        /// 土遁之术
        /// </summary>
        Doton = 2270,        
        /// <summary>
        /// 水遁之术
        /// </summary>
        Suiton = 2271,     
        /// <summary>
        /// 劫火灭却之术
        /// </summary>
        GokaMekkyaku = 16491,
        /// <summary>
        /// 冰晶乱流之术
        /// </summary>
        HyoshoRanryu = 16492,        
        #endregion

        #region PLD
        /// <summary>
        /// 钢铁信念
        /// </summary>
        IronWill = 28,
        /// <summary>
        /// 先锋剑
        /// </summary>
        FastBlade = 9,
        /// <summary>
        /// 暴乱剑
        /// </summary>
        RiotBlade = 15,
        /// <summary>
        /// 沥血剑
        /// </summary>
        GoringBlade = 3538,  
        /// <summary>
        /// 战女神之怒
        /// </summary>
        RageofHalone = 21,
        /// <summary>
        /// 王权剑
        /// </summary>
        RoyalAuthority = 3539,
        /// <summary>
        /// 投盾
        /// </summary>
        ShieldLob = 24,       
        /// <summary>
        /// 战逃反应
        /// </summary>
        FightorFlight = 20,      
        /// <summary>
        /// 全蚀斩
        /// </summary>
        TotalEclipse = 7381,
        /// <summary>
        /// 日珥斩
        /// </summary>
        Prominence = 16457,
        /// <summary>
        /// 预警
        /// </summary>
        Sentinel = 17,       
        /// <summary>
        /// 厄运流转
        /// </summary>
        CircleofScorn = 23,      
        /// <summary>
        /// 深奥之灵
        /// </summary>
        SpiritsWithin = 29,      
        /// <summary>
        /// 神圣领域
        /// </summary>
        HallowedGround = 30,       
        /// <summary>
        /// 圣光幕帘
        /// </summary>
        DivineVeil = 3540,
        /// <summary>
        /// 深仁厚泽
        /// </summary>
        Clemency = 3541,
        /// <summary>
        /// 干预
        /// </summary>
        Intervention = 7382,        
        /// <summary>
        /// 调停
        /// </summary>
        Intervene = 16461,        
        /// <summary>
        /// 赎罪剑
        /// </summary>
        Atonement = 16460,      
        /// <summary>
        /// 偿赎剑
        /// </summary>
        Expiacion = 25747,
        /// <summary>
        /// 英勇之剑
        /// </summary>
        BladeofValor = 25750,
        /// <summary>
        /// 真理之剑
        /// </summary>
        BladeofTruth = 25749,
        /// <summary>
        /// 信念之剑
        /// </summary>
        BladeofFaith = 25748,     
        /// <summary>
        /// 安魂祈祷
        /// </summary>
        Requiescat = 7383,
        /// <summary>
        /// 悔罪
        /// </summary>
        Confiteor = 16459,    
        /// <summary>
        /// 圣环
        /// </summary>
        HolyCircle = 16458,     
        /// <summary>
        /// 圣灵
        /// </summary>
        HolySpirit = 7384,   
        /// <summary>
        /// 武装戍卫
        /// </summary>
        PassageofArms = 7385,
        /// <summary>
        /// 保护
        /// </summary>
        Cover = 27,
        /// <summary>
        /// 盾阵
        /// </summary>
        Sheltron = 3542,        
        #endregion

        #region RDM
        /// <summary>
        /// 赤复活
        /// </summary>
        Verraise = 7523,
        /// <summary>
        /// 震荡
        /// </summary>
        Jolt = 7503,       
        /// <summary>
        /// 回刺
        /// </summary>
        Riposte = 7504,     
        /// <summary>
        /// 赤闪雷
        /// </summary>
        Verthunder = 7505,    
        //短兵相接
        CorpsAcorps = 7506,  
        /// <summary>
        /// 赤疾风
        /// </summary>
        Veraero = 7507,     
        /// <summary>
        /// 散碎
        /// </summary>
        Scatter = 7509,      
        /// <summary>
        /// 赤震雷
        /// </summary>
        Verthunder2 = 16524,     
        /// <summary>
        /// 赤烈风
        /// </summary>
        Veraero2 = 16525,      
        /// <summary>
        /// 赤火炎
        /// </summary>
        Verfire = 7510,      
        /// <summary>
        /// 赤飞石
        /// </summary>
        Verstone = 7511,     
        /// <summary>
        /// 交击斩
        /// </summary>
        Zwerchhau = 7512,    
        /// <summary>
        /// 交剑
        /// </summary>
        Engagement = 16527,
        /// <summary>
        /// 飞剑
        /// </summary>
        Fleche = 7517,
        /// <summary>
        /// 连攻
        /// </summary>
        Redoublement = 7516,     
        /// <summary>
        /// 促进
        /// </summary>
        Acceleration = 7518,      
        /// <summary>
        /// 划圆斩
        /// </summary>
        Moulinet = 7513,      
        /// <summary>
        /// 赤治疗
        /// </summary>
        Vercure = 7514,      
        /// <summary>
        /// 六分反击
        /// </summary>
        ContreSixte = 7519,
        /// <summary>
        /// 鼓励
        /// </summary>
        Embolden = 7520,
        /// <summary>
        /// 续斩
        /// </summary>
        Reprise = 16529,
        /// <summary>
        /// 抗死
        /// </summary>
        MagickBarrier = 25857,
        /// <summary>
        /// 赤核爆
        /// </summary>
        Verflare = 7525,
        /// <summary>
        /// 赤神圣
        /// </summary>
        Verholy = 7526,
        /// <summary>
        /// 焦热
        /// </summary>
        Scorch = 16530,       
        /// <summary>
        /// 决断
        /// </summary>
        Resolution = 25858,
        /// <summary>
        /// 魔元化
        /// </summary>
        Manafication = 7521,        
        #endregion

        #region RPR
        /// <summary>
        /// 切割
        /// </summary>
        Slice = 24373,  
        /// <summary>
        /// 增盈切割
        /// </summary>
        WaxingSlice = 24374,    
        /// <summary>
        /// 地狱切割
        /// </summary>
        InfernalSlice = 24375, 
        /// <summary>
        /// 死亡之影
        /// </summary>
        ShadowofDeath = 24378,   
        /// <summary>
        /// 灵魂切割
        /// </summary>
        SoulSlice = 24380,      
        /// <summary>
        /// 旋转钐割
        /// </summary>
        SpinningScythe = 24376,  
        /// <summary>
        /// 噩梦钐割
        /// </summary>
        NightmareScythe = 24377, 
        /// <summary>
        /// 死亡之涡
        /// </summary>
        WhorlofDeath = 24379,    
        /// <summary>
        /// 灵魂钐割
        /// </summary>
        SoulScythe = 24381,   
        /// <summary>
        /// 绞决
        /// </summary>
        Gibbet = 24382,       
        /// <summary>
        /// 缢杀
        /// </summary>
        Gallows = 24383,      
        /// <summary>
        /// 断首
        /// </summary>
        Guillotine = 24384,   
        /// <summary>
        /// 隐匿挥割
        /// </summary>
        BloodStalk = 24389,     
        /// <summary>
        /// 束缚挥割
        /// </summary>
        GrimSwathe = 24392,      
        /// <summary>
        /// 暴食
        /// </summary>
        Gluttony = 24393,       
        /// <summary>
        /// 神秘环
        /// </summary>
        ArcaneCircle = 24405,      
        /// <summary>
        /// 大丰收
        /// </summary>
        PlentifulHarvest = 24385,    
        /// <summary>
        /// 夜游魂衣
        /// </summary>
        Enshroud = 24394,       
        /// <summary>
        /// 团契
        /// </summary>
        Communio = 24398,      
        /// <summary>
        /// 夜游魂切割
        /// </summary>
        LemuresSlice = 24399,    
        /// <summary>
        /// 夜游魂钐割
        /// </summary>
        LemuresScythe = 24400,  
        /// <summary>
        /// 虚无收割
        /// </summary>
        VoidReaping = 24395,     
        /// <summary>
        /// 交错收割
        /// </summary>
        CrossReaping = 24396,     
        /// <summary>
        /// 阴冷收割
        /// </summary>
        GrimReaping = 24397,      
        /// <summary>
        /// 勾刃
        /// </summary>
        Harpe = 24386,
        /// <summary>
        /// 播魂种
        /// </summary>
        Soulsow = 24387,        
        /// <summary>
        /// 收获月
        /// </summary>
        HarvestMoon = 24388,       
        /// <summary>
        /// 神秘纹 加盾
        /// </summary>
        ArcaneCrest = 24404,        
        #endregion

        #region SAM
        /// <summary>
        /// 刃风
        /// </summary>
        Hakaze = 7477,
        /// <summary>
        /// 阵风
        /// </summary>
        Jinpu = 7478,
        /// <summary>
        /// 心眼
        /// </summary>
        ThirdEye = 7498,
        /// <summary>
        /// 燕飞
        /// </summary>
        Enpi = 7486,
        /// <summary>
        /// 士风
        /// </summary>
        Shifu = 7479,
        /// <summary>
        /// 风雅
        /// </summary>
        Fuga = 7483,
        /// <summary>
        /// 月光
        /// </summary>
        Gekko = 7481,
        /// <summary>
        /// 彼岸花
        /// </summary>
        Higanbana = 7489, 
        /// <summary>
        /// 天下五剑
        /// </summary>
        TenkaGoken = 7488,       
        /// <summary>
        /// 纷乱雪月花
        /// </summary>
        MidareSetsugekka = 7487,  
        /// <summary>
        /// 满月
        /// </summary>
        Mangetsu = 7484,
        /// <summary>
        /// 花车
        /// </summary>
        Kasha = 7482,
        /// <summary>
        /// 樱花
        /// </summary>
        Oka = 7485,
        /// <summary>
        /// 明镜止水
        /// </summary>
        MeikyoShisui = 7499,       
        /// <summary>
        /// 雪风
        /// </summary>
        Yukikaze = 7480,
        /// <summary>
        /// 必杀剑·晓天
        /// </summary>
        HissatsuGyoten = 7492,
        /// <summary>
        /// 必杀剑·震天
        /// </summary>
        HissatsuShinten = 7490,
        /// <summary>
        /// 必杀剑·九天
        /// </summary>
        HissatsuKyuten = 7491,
        /// <summary>
        /// 意气冲天
        /// </summary>
        Ikishoten = 16482,
        /// <summary>
        /// 必杀剑·红莲
        /// </summary>
        HissatsuGuren = 7496,
        /// <summary>
        /// 必杀剑·闪影
        /// </summary>
        HissatsuSenei = 16481,
        /// <summary>
        /// 回返五剑
        /// </summary>
        KaeshiGoken = 16485,
        /// <summary>
        /// 回返雪月花
        /// </summary>
        KaeshiSetsugekka = 16486,
        /// <summary>
        /// 照破
        /// </summary>
        Shoha = 16487,
        /// <summary>
        /// 无明照破
        /// </summary>
        Shoha2 = 25779,
        /// <summary>
        /// 奥义斩浪
        /// </summary>
        OgiNamikiri = 25781,      
        /// <summary>
        /// 回返斩浪
        /// </summary>
        KaeshiNamikiri = 25782,
        #endregion

        #region SCH
        /// <summary>
        /// 医术
        /// </summary>
        Physick = 190,
        /// <summary>
        /// 鼓舞激励之策
        /// </summary>
        Adloquium = 185,
        /// <summary>
        /// 复生
        /// </summary>
        Resurrection = 173,
        /// <summary>
        /// 士气高扬之策
        /// </summary>
        Succor = 186,        
        /// <summary>
        /// 生命活性法
        /// </summary>
        Lustrate = 189,   
        /// <summary>
        /// 野战治疗阵
        /// </summary>
        SacredSoil = 188,     
        /// <summary>
        /// 不屈不挠之策
        /// </summary>
        Indomitability = 3583, 
        /// <summary>
        /// 深谋远虑之策
        /// </summary>
        Excogitation = 7434,     
        /// <summary>
        /// 慰藉
        /// </summary>
        Consolation = 16546,    
        /// <summary>
        /// 生命回生法
        /// </summary>
        Protraction = 25867,        
        /// <summary>
        /// 毒菌
        /// </summary>
        Bio = 17864,     
        /// <summary>
        /// 毁灭
        /// </summary>
        Ruin = 17869,
        /// <summary>
        /// 毁坏
        /// </summary>
        Ruin2 = 17870,
        /// <summary>
        /// 能量吸收
        /// </summary>
        EnergyDrain = 167,    
        /// <summary>
        /// 破阵法
        /// </summary>
        ArtofWar = 16539,       
        /// <summary>
        /// 炽天召唤
        /// </summary>
        SummonSeraph = 16545,   
        /// <summary>
        /// 朝日召唤
        /// </summary>
        SummonEos = 17215,     
        /// <summary>
        /// 仙光的低语/天使的低语
        /// </summary>
        WhisperingDawn = 16537, 
        /// <summary>
        /// 异想的幻光/炽天的幻光
        /// </summary>
        FeyIllumination = 16538,  
        /// <summary>
        /// 转化
        /// </summary>
        Dissipation = 3587,      
        /// <summary>
        /// 以太契约-异想的融光
        /// </summary>
        Aetherpact = 7437,     
        /// <summary>
        /// 异想的祥光
        /// </summary>
        FeyBlessing = 16543,   
        /// <summary>
        /// 以太超流
        /// </summary>
        Aetherflow = 166,    
        /// <summary>
        /// 秘策
        /// </summary>
        Recitation = 16542,
        /// <summary>
        /// 连环计
        /// </summary>
        ChainStratagem = 7436,   
        /// <summary>
        /// 展开战术
        /// </summary>
        DeploymentTactics = 3585,        
        /// <summary>
        /// 应急战术
        /// </summary>
        EmergencyTactics = 3586,
        /// <summary>
        /// 疾风怒涛之计
        /// </summary>
        Expedient = 25868,        
        #endregion

        #region SGE
        /// <summary>
        /// 复苏
        /// </summary>
        Egeiro = 24287,
        /// <summary>
        /// 注药
        /// </summary>
        Dosis = 24283,
        /// <summary>
        /// 均衡注药
        /// </summary>
        EukrasianDosis = 24283,        
        /// <summary>
        /// 发炎
        /// </summary>
        Phlegma = 24289,
        /// <summary>
        /// 发炎2
        /// </summary>
        Phlegma2 = 24307,
        /// <summary>
        /// 发炎3
        /// </summary>
        Phlegma3 = 24313,
        /// <summary>
        /// 诊断
        /// </summary>
        Diagnosis = 24284,
        /// <summary>
        /// 心关
        /// </summary>
        Kardia = 24285,        
        /// <summary>
        /// 预后
        /// </summary>
        Prognosis = 24286,
        /// <summary>
        /// 自生
        /// </summary>
        Physis = 24288,
        /// <summary>
        /// 自生2
        /// </summary>
        Physis2 = 24302,
        /// <summary>
        /// 均衡
        /// </summary>
        Eukrasia = 24290,       
        /// <summary>
        /// 拯救
        /// </summary>
        Soteria = 24294,     
        /// <summary>
        /// 神翼
        /// </summary>
        Icarus = 24295,       
        /// <summary>
        /// 灵橡清汁
        /// </summary>
        Druochole = 24296,        
        /// <summary>
        /// 失衡
        /// </summary>
        Dyskrasia = 24297,
        /// <summary>
        /// 坚角清汁
        /// </summary>
        Kerachole = 24298,       
        /// <summary>
        /// 寄生清汁
        /// </summary>
        Ixochole = 24299,       
        /// <summary>
        /// 活化
        /// </summary>
        Zoe = 24300,
        /// <summary>
        /// 白牛清汁
        /// </summary>
        Taurochole = 24303,       
        /// <summary>
        /// 箭毒
        /// </summary>
        Toxikon = 24304,
        /// <summary>
        /// 输血
        /// </summary>
        Haima = 24305,        
        /// <summary>
        /// 均衡诊断
        /// </summary>
        EukrasianDiagnosis = 24291,        
        /// <summary>
        /// 均衡预后
        /// </summary>
        EukrasianPrognosis = 24292,        
        /// <summary>
        /// 根素
        /// </summary>
        Rhizomata = 24309,
        /// <summary>
        /// 整体论
        /// </summary>
        Holos = 24310,
        /// <summary>
        /// 泛输血
        /// </summary>
        Panhaima = 24311,
        /// <summary>
        /// 混合
        /// </summary>
        Krasis = 24317,
        /// <summary>
        /// 魂灵风息
        /// </summary>
        Pneuma = 24318,
        /// <summary>
        /// 消化
        /// </summary>
        Pepsis = 24301,
        #endregion

        #region SMN
        /// <summary>
        /// 宝石耀
        /// </summary>
        Gemshine = 25883,
        /// <summary>
        /// 宝石辉
        /// </summary>
        PreciousBrilliance = 25884,
        /// <summary>
        /// 毁灭
        /// </summary>
        Ruin = 163,
        /// <summary>
        /// 迸裂
        /// </summary>
        Outburst = 16511,
        /// <summary>
        /// 宝石兽召唤
        /// </summary>
        SummonCarbuncle = 25798,       
        /// <summary>
        /// 灼热之光 团辅
        /// </summary>
        SearingLight = 25801,      
        /// <summary>
        /// 守护之光
        /// </summary>
        RadiantAegis = 25799,
        /// <summary>
        /// 医术
        /// </summary>
        Physick = 16230,
        /// <summary>
        /// 以太蓄能 
        /// </summary>
        Aethercharge = 25800,    
        /// <summary>
        /// 龙神召唤
        /// </summary>
        SummonBahamut = 7427,
        /// <summary>
        /// 红宝石召唤
        /// </summary>
        SummonRuby = 25802,      
        /// <summary>
        /// 黄宝石召唤
        /// </summary>
        SummonTopaz = 25803,
        /// <summary>
        /// 绿宝石召唤
        /// </summary>
        SummonEmerald = 25804,
        /// <summary>
        /// 复生
        /// </summary>
        Resurrection = 173,
        /// <summary>
        /// 能量吸收
        /// </summary>
        EnergyDrain = 16508,
        /// <summary>
        /// 能量抽取
        /// </summary>
        EnergySiphon = 16510,
        /// <summary>
        /// 溃烂爆发
        /// </summary>
        Fester = 181,
        /// <summary>
        /// 痛苦核爆
        /// </summary>
        Painflare = 3578,
        /// <summary>
        /// 毁绝
        /// </summary>
        RuinIV = 7426,
        /// <summary>
        /// 龙神迸发
        /// </summary>
        EnkindleBahamut = 7429,
        /// <summary>
        /// 死星核爆
        /// </summary>
        Deathflare = 3582,
        /// <summary>
        /// 苏生之炎
        /// </summary>
        Rekindle = 25830,
        /// <summary>
        /// 深红旋风
        /// </summary>
        CrimsonCyclone = 25835,
        /// <summary>
        /// 深红强袭
        /// </summary>
        CrimsonStrike = 25885,
        /// <summary>
        /// 山崩
        /// </summary>
        MountainBuster = 25836,
        /// <summary>
        /// 螺旋气流
        /// </summary>
        Slipstream = 25837,
        #endregion

        #region WAR
        /// <summary>
        /// 守护
        /// </summary>
        Defiance = 48,
        /// <summary>
        /// 重劈
        /// </summary>
        HeavySwing = 31,
        /// <summary>
        /// 凶残裂
        /// </summary>
        Maim = 37,
        /// <summary>
        /// 暴风斩
        /// </summary>
        StormsPath = 42,
        /// <summary>
        /// 暴风碎 红斧
        /// </summary>
        StormsEye = 45,
        /// <summary>
        /// 飞斧
        /// </summary>
        Tomahawk = 46,
        /// <summary>
        /// 猛攻
        /// </summary>
        Onslaught = 7386,
        /// <summary>
        /// 动乱    
        /// </summary>
        Upheaval = 7387,
        /// <summary>
        /// 超压斧
        /// </summary>
        Overpower = 41,
        /// <summary>
        /// 秘银暴风
        /// </summary>
        MythrilTempest = 16462,
        /// <summary>
        /// 群山隆起
        /// </summary>
        Orogeny = 25752,
        /// <summary>
        /// 原初之魂
        /// </summary>
        InnerBeast = 49,
        /// <summary>
        /// 钢铁旋风
        /// </summary>
        SteelCyclone = 51,
        /// <summary>
        /// 战嚎
        /// </summary>
        Infuriate = 52,
        /// <summary>
        /// 狂暴
        /// </summary>
        Berserk = 38,
        /// <summary>
        /// 战栗
        /// </summary>
        ThrillofBattle = 40,
        /// <summary>
        /// 泰然自若
        /// </summary>
        Equilibrium = 3552,
        /// <summary>
        /// 原初的勇猛
        /// </summary>
        NascentFlash = 16464,
        /// <summary>
        /// 原初的血气
        /// </summary>
        Bloodwhetting = 25751,
        /// <summary>
        /// 复仇
        /// </summary>
        Vengeance = 44,
        /// <summary>
        /// 原初的直觉
        /// </summary>
        RawIntuition = 3551,
        /// <summary>
        /// 摆脱
        /// </summary>
        ShakeItOff = 7388,
        /// <summary>
        /// 死斗
        /// </summary>
        Holmgang = 43,
        /// <summary>
        /// 原初的解放
        /// </summary>
        InnerRelease = 7389,
        /// <summary>
        /// 蛮荒崩裂
        /// </summary>
        PrimalRend = 25753,
        #endregion

        #region WHM
        /// <summary>
        /// 治疗
        /// </summary>
        Cure = 120,
        /// <summary>
        /// 医治
        /// </summary>
        Medica = 124,
        /// <summary>
        /// 复活
        /// </summary>
        Raise1 = 125,
        /// <summary>
        /// 救疗
        /// </summary>
        Cure2 = 135,
        /// <summary>
        /// 医济
        /// </summary>
        Medica2 = 133,
        /// <summary>
        /// 再生
        /// </summary>
        Regen = 137,
        /// <summary>
        /// 愈疗
        /// </summary>
        Cure3 = 131,
        /// <summary>
        /// 天赐祝福
        /// </summary>
        Benediction = 140,
        /// <summary>
        /// 庇护所
        /// </summary>
        Asylum = 3569,
        /// <summary>
        /// 安慰之心
        /// </summary>
        AfflatusSolace = 16531,
        /// <summary>
        /// 神名
        /// </summary>
        Tetragrammaton = 3570,
        /// <summary>
        /// 神祝祷
        /// </summary>
        DivineBenison = 7432,
        /// <summary>
        /// 狂喜之心
        /// </summary>
        AfflatusRapture = 16534,
        /// <summary>
        /// 水流幕
        /// </summary>
        Aquaveil = 25861,
        /// <summary>
        /// 礼仪之铃
        /// </summary>
        LiturgyoftheBell = 25862,
        /// <summary>
        /// 飞石 
        /// </summary>
        Stone = 119,
        /// <summary>
        /// 疾风
        /// </summary>
        Aero = 121,
        /// <summary>
        /// 神圣
        /// </summary>
        Holy = 139,
        /// <summary>
        /// 法令
        /// </summary>
        Assize = 3571,
        /// <summary>
        /// 苦难之心
        /// </summary>
        AfflatusMisery = 16535,
        /// <summary>
        /// 神速咏唱
        /// </summary>
        PresenseOfMind = 136,
        /// <summary>
        /// 无中生有
        /// </summary>
        ThinAir = 7430,
        /// <summary>
        /// 全大赦
        /// </summary>
        PlenaryIndulgence = 7433,
        /// <summary>
        /// 节制
        /// </summary>
        Temperance = 16536,
        #endregion

    }
}
