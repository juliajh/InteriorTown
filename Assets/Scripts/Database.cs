using System;
using System.Collections.Generic;
using BansheeGz.BGDatabase;

//=============================================================
//||                   Generated by BansheeGz Code Generator ||
//=============================================================

#pragma warning disable 414

public partial class TBL_SOFA : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_SOFA(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_SOFA(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5413355810449227054UL,5588347537935064710UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	public UnityEngine.Sprite RightImage => _RightImage[Index];
	public UnityEngine.Sprite BottomImage => _BottomImage[Index];
	public UnityEngine.Sprite LeftImage => _LeftImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5507460022406674585UL, 6109536621842896567UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(5737661778298655789UL, 91334704520282029UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5398925878853855407UL, 13107495127626052026UL), () => _ufle12jhs77_FrontImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_RightImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _RightImage => _ufle12jhs77_RightImage ?? (_ufle12jhs77_RightImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(4737381264901370988UL, 12278017522003901859UL), () => _ufle12jhs77_RightImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_BottomImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _BottomImage => _ufle12jhs77_BottomImage ?? (_ufle12jhs77_BottomImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(4863820707875751196UL, 5461111490820717450UL), () => _ufle12jhs77_BottomImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_LeftImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _LeftImage => _ufle12jhs77_LeftImage ?? (_ufle12jhs77_LeftImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5576138691180531966UL, 16571534555718588830UL), () => _ufle12jhs77_LeftImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_SOFA() : base(MetaDefault)
	{
	}
	private TBL_SOFA(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_SOFA(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_SOFA(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_SOFA FindEntity(Predicate<TBL_SOFA> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_SOFA) entity)) as TBL_SOFA;
	}
	public static List<TBL_SOFA> FindEntities(Predicate<TBL_SOFA> filter, List<TBL_SOFA> result=null, Comparison<TBL_SOFA> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_SOFA> action, Predicate<TBL_SOFA> filter=null, Comparison<TBL_SOFA> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_SOFA) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_SOFA) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_SOFA)e1,(TBL_SOFA)e2));
	}
	public static TBL_SOFA GetEntity(BGId entityId) => (TBL_SOFA) MetaDefault.GetEntity(entityId);
	public static TBL_SOFA GetEntity(int index) => (TBL_SOFA) MetaDefault[index];
	public static TBL_SOFA GetEntity(string entityName) => (TBL_SOFA) MetaDefault.GetEntity(entityName);
	public static TBL_SOFA NewEntity() => (TBL_SOFA) MetaDefault.NewEntity();
	public static TBL_SOFA NewEntity(BGId entityId) => (TBL_SOFA) MetaDefault.NewEntity(entityId);
	public static TBL_SOFA NewEntity(Action<TBL_SOFA> callback)
	{
		return (TBL_SOFA) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_SOFA)entity)));
	}
}

public partial class TBL_BED : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_BED(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_BED(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5689327529558403248UL,8868986883723209607UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	public UnityEngine.Sprite RightImage => _RightImage[Index];
	public UnityEngine.Sprite LeftImage => _LeftImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5420103927363876683UL, 16097895772021040287UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(4808520540688666834UL, 12953271441959135129UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5044473270942319245UL, 16584329550614865598UL), () => _ufle12jhs77_FrontImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_RightImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _RightImage => _ufle12jhs77_RightImage ?? (_ufle12jhs77_RightImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5163735327953760980UL, 10331764183982733975UL), () => _ufle12jhs77_RightImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_LeftImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _LeftImage => _ufle12jhs77_LeftImage ?? (_ufle12jhs77_LeftImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(4644110007338102818UL, 7518603077722399653UL), () => _ufle12jhs77_LeftImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_BED() : base(MetaDefault)
	{
	}
	private TBL_BED(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_BED(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_BED(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_BED FindEntity(Predicate<TBL_BED> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_BED) entity)) as TBL_BED;
	}
	public static List<TBL_BED> FindEntities(Predicate<TBL_BED> filter, List<TBL_BED> result=null, Comparison<TBL_BED> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_BED> action, Predicate<TBL_BED> filter=null, Comparison<TBL_BED> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_BED) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_BED) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_BED)e1,(TBL_BED)e2));
	}
	public static TBL_BED GetEntity(BGId entityId) => (TBL_BED) MetaDefault.GetEntity(entityId);
	public static TBL_BED GetEntity(int index) => (TBL_BED) MetaDefault[index];
	public static TBL_BED GetEntity(string entityName) => (TBL_BED) MetaDefault.GetEntity(entityName);
	public static TBL_BED NewEntity() => (TBL_BED) MetaDefault.NewEntity();
	public static TBL_BED NewEntity(BGId entityId) => (TBL_BED) MetaDefault.NewEntity(entityId);
	public static TBL_BED NewEntity(Action<TBL_BED> callback)
	{
		return (TBL_BED) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_BED)entity)));
	}
}

public partial class TBL_CHAIR : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_CHAIR(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_CHAIR(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5522386408971569535UL,10942013481855679666UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	public UnityEngine.Sprite RightImage => _RightImage[Index];
	public UnityEngine.Sprite BottomImage => _BottomImage[Index];
	public UnityEngine.Sprite LeftImage => _LeftImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(4879575727926648537UL, 15341578675712528267UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(4673205343357341530UL, 11131196012646189247UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5634979767121468667UL, 3818244007430112134UL), () => _ufle12jhs77_FrontImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_RightImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _RightImage => _ufle12jhs77_RightImage ?? (_ufle12jhs77_RightImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5489056986761806797UL, 17878395233564052921UL), () => _ufle12jhs77_RightImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_BottomImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _BottomImage => _ufle12jhs77_BottomImage ?? (_ufle12jhs77_BottomImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5017784547949416554UL, 12062608863859493008UL), () => _ufle12jhs77_BottomImage = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_LeftImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _LeftImage => _ufle12jhs77_LeftImage ?? (_ufle12jhs77_LeftImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5519275783039438080UL, 172062949677703856UL), () => _ufle12jhs77_LeftImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_CHAIR() : base(MetaDefault)
	{
	}
	private TBL_CHAIR(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_CHAIR(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_CHAIR(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_CHAIR FindEntity(Predicate<TBL_CHAIR> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_CHAIR) entity)) as TBL_CHAIR;
	}
	public static List<TBL_CHAIR> FindEntities(Predicate<TBL_CHAIR> filter, List<TBL_CHAIR> result=null, Comparison<TBL_CHAIR> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_CHAIR> action, Predicate<TBL_CHAIR> filter=null, Comparison<TBL_CHAIR> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_CHAIR) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_CHAIR) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_CHAIR)e1,(TBL_CHAIR)e2));
	}
	public static TBL_CHAIR GetEntity(BGId entityId) => (TBL_CHAIR) MetaDefault.GetEntity(entityId);
	public static TBL_CHAIR GetEntity(int index) => (TBL_CHAIR) MetaDefault[index];
	public static TBL_CHAIR GetEntity(string entityName) => (TBL_CHAIR) MetaDefault.GetEntity(entityName);
	public static TBL_CHAIR NewEntity() => (TBL_CHAIR) MetaDefault.NewEntity();
	public static TBL_CHAIR NewEntity(BGId entityId) => (TBL_CHAIR) MetaDefault.NewEntity(entityId);
	public static TBL_CHAIR NewEntity(Action<TBL_CHAIR> callback)
	{
		return (TBL_CHAIR) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_CHAIR)entity)));
	}
}

public partial class TBL_STAND : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_STAND(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_STAND(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5423560698093805523UL,5966059715210335872UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5065691844626759308UL, 2719437684810685856UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(4623604759171456068UL, 16211250140699301540UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5237184440970635494UL, 4797762018031622538UL), () => _ufle12jhs77_FrontImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_STAND() : base(MetaDefault)
	{
	}
	private TBL_STAND(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_STAND(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_STAND(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_STAND FindEntity(Predicate<TBL_STAND> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_STAND) entity)) as TBL_STAND;
	}
	public static List<TBL_STAND> FindEntities(Predicate<TBL_STAND> filter, List<TBL_STAND> result=null, Comparison<TBL_STAND> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_STAND> action, Predicate<TBL_STAND> filter=null, Comparison<TBL_STAND> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_STAND) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_STAND) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_STAND)e1,(TBL_STAND)e2));
	}
	public static TBL_STAND GetEntity(BGId entityId) => (TBL_STAND) MetaDefault.GetEntity(entityId);
	public static TBL_STAND GetEntity(int index) => (TBL_STAND) MetaDefault[index];
	public static TBL_STAND GetEntity(string entityName) => (TBL_STAND) MetaDefault.GetEntity(entityName);
	public static TBL_STAND NewEntity() => (TBL_STAND) MetaDefault.NewEntity();
	public static TBL_STAND NewEntity(BGId entityId) => (TBL_STAND) MetaDefault.NewEntity(entityId);
	public static TBL_STAND NewEntity(Action<TBL_STAND> callback)
	{
		return (TBL_STAND) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_STAND)entity)));
	}
}

public partial class TBL_BOOKSHELF : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_BOOKSHELF(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_BOOKSHELF(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(4653189658008874054UL,11864226530407332230UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5201778692083329690UL, 9405238905157460619UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(5153622061817643673UL, 11707279000427428254UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(4671279560622072576UL, 3810990039927748024UL), () => _ufle12jhs77_FrontImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_BOOKSHELF() : base(MetaDefault)
	{
	}
	private TBL_BOOKSHELF(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_BOOKSHELF(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_BOOKSHELF(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_BOOKSHELF FindEntity(Predicate<TBL_BOOKSHELF> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_BOOKSHELF) entity)) as TBL_BOOKSHELF;
	}
	public static List<TBL_BOOKSHELF> FindEntities(Predicate<TBL_BOOKSHELF> filter, List<TBL_BOOKSHELF> result=null, Comparison<TBL_BOOKSHELF> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_BOOKSHELF> action, Predicate<TBL_BOOKSHELF> filter=null, Comparison<TBL_BOOKSHELF> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_BOOKSHELF) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_BOOKSHELF) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_BOOKSHELF)e1,(TBL_BOOKSHELF)e2));
	}
	public static TBL_BOOKSHELF GetEntity(BGId entityId) => (TBL_BOOKSHELF) MetaDefault.GetEntity(entityId);
	public static TBL_BOOKSHELF GetEntity(int index) => (TBL_BOOKSHELF) MetaDefault[index];
	public static TBL_BOOKSHELF GetEntity(string entityName) => (TBL_BOOKSHELF) MetaDefault.GetEntity(entityName);
	public static TBL_BOOKSHELF NewEntity() => (TBL_BOOKSHELF) MetaDefault.NewEntity();
	public static TBL_BOOKSHELF NewEntity(BGId entityId) => (TBL_BOOKSHELF) MetaDefault.NewEntity(entityId);
	public static TBL_BOOKSHELF NewEntity(Action<TBL_BOOKSHELF> callback)
	{
		return (TBL_BOOKSHELF) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_BOOKSHELF)entity)));
	}
}

public partial class TBL_FLOWERPOT : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_FLOWERPOT(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_FLOWERPOT(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5203051076449232090UL,18398173021297157812UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5041410854864211735UL, 10813666471851790986UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5739542114586080356UL, 13300557023371103904UL), () => _ufle12jhs77_FrontImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_FLOWERPOT() : base(MetaDefault)
	{
	}
	private TBL_FLOWERPOT(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_FLOWERPOT(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_FLOWERPOT(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_FLOWERPOT FindEntity(Predicate<TBL_FLOWERPOT> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_FLOWERPOT) entity)) as TBL_FLOWERPOT;
	}
	public static List<TBL_FLOWERPOT> FindEntities(Predicate<TBL_FLOWERPOT> filter, List<TBL_FLOWERPOT> result=null, Comparison<TBL_FLOWERPOT> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_FLOWERPOT> action, Predicate<TBL_FLOWERPOT> filter=null, Comparison<TBL_FLOWERPOT> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_FLOWERPOT) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_FLOWERPOT) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_FLOWERPOT)e1,(TBL_FLOWERPOT)e2));
	}
	public static TBL_FLOWERPOT GetEntity(BGId entityId) => (TBL_FLOWERPOT) MetaDefault.GetEntity(entityId);
	public static TBL_FLOWERPOT GetEntity(int index) => (TBL_FLOWERPOT) MetaDefault[index];
	public static TBL_FLOWERPOT GetEntity(string entityName) => (TBL_FLOWERPOT) MetaDefault.GetEntity(entityName);
	public static TBL_FLOWERPOT NewEntity() => (TBL_FLOWERPOT) MetaDefault.NewEntity();
	public static TBL_FLOWERPOT NewEntity(BGId entityId) => (TBL_FLOWERPOT) MetaDefault.NewEntity(entityId);
	public static TBL_FLOWERPOT NewEntity(Action<TBL_FLOWERPOT> callback)
	{
		return (TBL_FLOWERPOT) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_FLOWERPOT)entity)));
	}
}

public partial class TBL_PHOTOFRAME : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_PHOTOFRAME(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_PHOTOFRAME(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5131019977078645713UL,9658282602289030300UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5473670791692288804UL, 11290559141127191700UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5564057947300978356UL, 16430213800666331552UL), () => _ufle12jhs77_FrontImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_PHOTOFRAME() : base(MetaDefault)
	{
	}
	private TBL_PHOTOFRAME(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_PHOTOFRAME(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_PHOTOFRAME(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_PHOTOFRAME FindEntity(Predicate<TBL_PHOTOFRAME> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_PHOTOFRAME) entity)) as TBL_PHOTOFRAME;
	}
	public static List<TBL_PHOTOFRAME> FindEntities(Predicate<TBL_PHOTOFRAME> filter, List<TBL_PHOTOFRAME> result=null, Comparison<TBL_PHOTOFRAME> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_PHOTOFRAME> action, Predicate<TBL_PHOTOFRAME> filter=null, Comparison<TBL_PHOTOFRAME> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_PHOTOFRAME) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_PHOTOFRAME) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_PHOTOFRAME)e1,(TBL_PHOTOFRAME)e2));
	}
	public static TBL_PHOTOFRAME GetEntity(BGId entityId) => (TBL_PHOTOFRAME) MetaDefault.GetEntity(entityId);
	public static TBL_PHOTOFRAME GetEntity(int index) => (TBL_PHOTOFRAME) MetaDefault[index];
	public static TBL_PHOTOFRAME GetEntity(string entityName) => (TBL_PHOTOFRAME) MetaDefault.GetEntity(entityName);
	public static TBL_PHOTOFRAME NewEntity() => (TBL_PHOTOFRAME) MetaDefault.NewEntity();
	public static TBL_PHOTOFRAME NewEntity(BGId entityId) => (TBL_PHOTOFRAME) MetaDefault.NewEntity(entityId);
	public static TBL_PHOTOFRAME NewEntity(Action<TBL_PHOTOFRAME> callback)
	{
		return (TBL_PHOTOFRAME) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_PHOTOFRAME)entity)));
	}
}

public partial class TBL_DESK : BGEntity
{

	public class Factory : BGEntity.EntityFactory
	{
		public BGEntity NewEntity(BGMetaEntity meta) => new TBL_DESK(meta);
		public BGEntity NewEntity(BGMetaEntity meta, BGId id) => new TBL_DESK(meta, id);
	}
	private static BansheeGz.BGDatabase.BGMetaRow _metaDefault;
	public static BansheeGz.BGDatabase.BGMetaRow MetaDefault => _metaDefault ?? (_metaDefault = BGCodeGenUtils.GetMeta<BansheeGz.BGDatabase.BGMetaRow>(new BGId(5058053138295434458UL,5500215346036464008UL), () => _metaDefault = null));
	public static BansheeGz.BGDatabase.BGRepoEvents Events => BGRepo.I.Events;
	public static int CountEntities => MetaDefault.CountEntities;
	public System.String name
	{
		get => _name[Index];
		set => _name[Index] = value;
	}
	public ColorType ColorType
	{
		get => (ColorType) _ColorType[Index];
		set => _ColorType[Index] = value;
	}
	public UnityEngine.Sprite FrontImage => _FrontImage[Index];
	private static BansheeGz.BGDatabase.BGFieldEntityName _ufle12jhs77_name;
	public static BansheeGz.BGDatabase.BGFieldEntityName _name => _ufle12jhs77_name ?? (_ufle12jhs77_name = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEntityName>(MetaDefault, new BGId(5479762493859594800UL, 13565908832271032723UL), () => _ufle12jhs77_name = null));
	private static BansheeGz.BGDatabase.BGFieldEnum _ufle12jhs77_ColorType;
	public static BansheeGz.BGDatabase.BGFieldEnum _ColorType => _ufle12jhs77_ColorType ?? (_ufle12jhs77_ColorType = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldEnum>(MetaDefault, new BGId(5616580997339418073UL, 12244329598197199797UL), () => _ufle12jhs77_ColorType = null));
	private static BansheeGz.BGDatabase.BGFieldUnitySprite _ufle12jhs77_FrontImage;
	public static BansheeGz.BGDatabase.BGFieldUnitySprite _FrontImage => _ufle12jhs77_FrontImage ?? (_ufle12jhs77_FrontImage = BGCodeGenUtils.GetField<BansheeGz.BGDatabase.BGFieldUnitySprite>(MetaDefault, new BGId(5412293100072137544UL, 11960746287224655794UL), () => _ufle12jhs77_FrontImage = null));
	private static readonly TBL_SOFA.Factory _factory0_PFS = new TBL_SOFA.Factory();
	private static readonly TBL_BED.Factory _factory1_PFS = new TBL_BED.Factory();
	private static readonly TBL_CHAIR.Factory _factory2_PFS = new TBL_CHAIR.Factory();
	private static readonly TBL_STAND.Factory _factory3_PFS = new TBL_STAND.Factory();
	private static readonly TBL_BOOKSHELF.Factory _factory4_PFS = new TBL_BOOKSHELF.Factory();
	private static readonly TBL_FLOWERPOT.Factory _factory5_PFS = new TBL_FLOWERPOT.Factory();
	private static readonly TBL_PHOTOFRAME.Factory _factory6_PFS = new TBL_PHOTOFRAME.Factory();
	private static readonly TBL_DESK.Factory _factory7_PFS = new TBL_DESK.Factory();
	private TBL_DESK() : base(MetaDefault)
	{
	}
	private TBL_DESK(BGId id) : base(MetaDefault, id)
	{
	}
	private TBL_DESK(BGMetaEntity meta) : base(meta)
	{
	}
	private TBL_DESK(BGMetaEntity meta, BGId id) : base(meta, id)
	{
	}
	public static TBL_DESK FindEntity(Predicate<TBL_DESK> filter)
	{
		return MetaDefault.FindEntity(entity => filter==null || filter((TBL_DESK) entity)) as TBL_DESK;
	}
	public static List<TBL_DESK> FindEntities(Predicate<TBL_DESK> filter, List<TBL_DESK> result=null, Comparison<TBL_DESK> sort=null) => BGCodeGenUtils.FindEntities(MetaDefault, filter, result, sort);
	public static void ForEachEntity(Action<TBL_DESK> action, Predicate<TBL_DESK> filter=null, Comparison<TBL_DESK> sort=null)
	{
		MetaDefault.ForEachEntity(entity => action((TBL_DESK) entity), filter == null ? null : (Predicate<BGEntity>) (entity => filter((TBL_DESK) entity)), sort==null?(Comparison<BGEntity>) null:(e1,e2) => sort((TBL_DESK)e1,(TBL_DESK)e2));
	}
	public static TBL_DESK GetEntity(BGId entityId) => (TBL_DESK) MetaDefault.GetEntity(entityId);
	public static TBL_DESK GetEntity(int index) => (TBL_DESK) MetaDefault[index];
	public static TBL_DESK GetEntity(string entityName) => (TBL_DESK) MetaDefault.GetEntity(entityName);
	public static TBL_DESK NewEntity() => (TBL_DESK) MetaDefault.NewEntity();
	public static TBL_DESK NewEntity(BGId entityId) => (TBL_DESK) MetaDefault.NewEntity(entityId);
	public static TBL_DESK NewEntity(Action<TBL_DESK> callback)
	{
		return (TBL_DESK) MetaDefault.NewEntity(new BGMetaEntity.NewEntityContext(entity => callback((TBL_DESK)entity)));
	}
}
#pragma warning restore 414
