// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: service_storequery.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.WebUI.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_GetItemsByUserRecommendedTags_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2)]
        public CStorePageFilter filters { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public StoreBrowseContext context { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<CStoreQuery_GetItemsByUserRecommendedTags_Request_Section> sections { get; } = new global::System.Collections.Generic.List<CStoreQuery_GetItemsByUserRecommendedTags_Request_Section>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_GetItemsByUserRecommendedTags_Request_Section : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int sort
        {
            get => __pbn__sort ?? 0;
            set => __pbn__sort = value;
        }
        public bool ShouldSerializesort() => __pbn__sort != null;
        public void Resetsort() => __pbn__sort = null;
        private int? __pbn__sort;

        [global::ProtoBuf.ProtoMember(2)]
        public uint min_items
        {
            get => __pbn__min_items.GetValueOrDefault();
            set => __pbn__min_items = value;
        }
        public bool ShouldSerializemin_items() => __pbn__min_items != null;
        public void Resetmin_items() => __pbn__min_items = null;
        private uint? __pbn__min_items;

        [global::ProtoBuf.ProtoMember(3)]
        public bool randomize
        {
            get => __pbn__randomize.GetValueOrDefault();
            set => __pbn__randomize = value;
        }
        public bool ShouldSerializerandomize() => __pbn__randomize != null;
        public void Resetrandomize() => __pbn__randomize = null;
        private bool? __pbn__randomize;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool include_packages
        {
            get => __pbn__include_packages ?? false;
            set => __pbn__include_packages = value;
        }
        public bool ShouldSerializeinclude_packages() => __pbn__include_packages != null;
        public void Resetinclude_packages() => __pbn__include_packages = null;
        private bool? __pbn__include_packages;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool include_bundles
        {
            get => __pbn__include_bundles ?? false;
            set => __pbn__include_bundles = value;
        }
        public bool ShouldSerializeinclude_bundles() => __pbn__include_bundles != null;
        public void Resetinclude_bundles() => __pbn__include_bundles = null;
        private bool? __pbn__include_bundles;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_GetItemsByUserRecommendedTags_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CStoreQuery_GetItemsByUserRecommendedTags_Response_Section> sections { get; } = new global::System.Collections.Generic.List<CStoreQuery_GetItemsByUserRecommendedTags_Response_Section>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_GetItemsByUserRecommendedTags_Response_Section : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint tagid
        {
            get => __pbn__tagid.GetValueOrDefault();
            set => __pbn__tagid = value;
        }
        public bool ShouldSerializetagid() => __pbn__tagid != null;
        public void Resettagid() => __pbn__tagid = null;
        private uint? __pbn__tagid;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<StoreItemID> store_item_ids { get; } = new global::System.Collections.Generic.List<StoreItemID>();

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tag_name
        {
            get => __pbn__tag_name ?? "";
            set => __pbn__tag_name = value;
        }
        public bool ShouldSerializetag_name() => __pbn__tag_name != null;
        public void Resettag_name() => __pbn__tag_name = null;
        private string __pbn__tag_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_Query_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string query_name
        {
            get => __pbn__query_name ?? "";
            set => __pbn__query_name = value;
        }
        public bool ShouldSerializequery_name() => __pbn__query_name != null;
        public void Resetquery_name() => __pbn__query_name = null;
        private string __pbn__query_name;

        [global::ProtoBuf.ProtoMember(2)]
        public CStoreQueryParams query { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public StoreBrowseContext context { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public StoreBrowseItemDataRequest data_request { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string override_country_code
        {
            get => __pbn__override_country_code ?? "";
            set => __pbn__override_country_code = value;
        }
        public bool ShouldSerializeoverride_country_code() => __pbn__override_country_code != null;
        public void Resetoverride_country_code() => __pbn__override_country_code = null;
        private string __pbn__override_country_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_Query_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CStoreQueryResultMetadata metadata { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<StoreItemID> ids { get; } = new global::System.Collections.Generic.List<StoreItemID>();

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<StoreItem> store_items { get; } = new global::System.Collections.Generic.List<StoreItem>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_SearchSuggestions_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string query_name
        {
            get => __pbn__query_name ?? "";
            set => __pbn__query_name = value;
        }
        public bool ShouldSerializequery_name() => __pbn__query_name != null;
        public void Resetquery_name() => __pbn__query_name = null;
        private string __pbn__query_name;

        [global::ProtoBuf.ProtoMember(2)]
        public StoreBrowseContext context { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string search_term
        {
            get => __pbn__search_term ?? "";
            set => __pbn__search_term = value;
        }
        public bool ShouldSerializesearch_term() => __pbn__search_term != null;
        public void Resetsearch_term() => __pbn__search_term = null;
        private string __pbn__search_term;

        [global::ProtoBuf.ProtoMember(4)]
        public uint max_results
        {
            get => __pbn__max_results.GetValueOrDefault();
            set => __pbn__max_results = value;
        }
        public bool ShouldSerializemax_results() => __pbn__max_results != null;
        public void Resetmax_results() => __pbn__max_results = null;
        private uint? __pbn__max_results;

        [global::ProtoBuf.ProtoMember(5)]
        public CStoreQueryFilters filters { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public StoreBrowseItemDataRequest data_request { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public bool use_spellcheck
        {
            get => __pbn__use_spellcheck.GetValueOrDefault();
            set => __pbn__use_spellcheck = value;
        }
        public bool ShouldSerializeuse_spellcheck() => __pbn__use_spellcheck != null;
        public void Resetuse_spellcheck() => __pbn__use_spellcheck = null;
        private bool? __pbn__use_spellcheck;

        [global::ProtoBuf.ProtoMember(8)]
        public bool search_tags
        {
            get => __pbn__search_tags.GetValueOrDefault();
            set => __pbn__search_tags = value;
        }
        public bool ShouldSerializesearch_tags() => __pbn__search_tags != null;
        public void Resetsearch_tags() => __pbn__search_tags = null;
        private bool? __pbn__search_tags;

        [global::ProtoBuf.ProtoMember(9)]
        public bool search_creators
        {
            get => __pbn__search_creators.GetValueOrDefault();
            set => __pbn__search_creators = value;
        }
        public bool ShouldSerializesearch_creators() => __pbn__search_creators != null;
        public void Resetsearch_creators() => __pbn__search_creators = null;
        private bool? __pbn__search_creators;

        [global::ProtoBuf.ProtoMember(10)]
        public bool prefilter_creators
        {
            get => __pbn__prefilter_creators.GetValueOrDefault();
            set => __pbn__prefilter_creators = value;
        }
        public bool ShouldSerializeprefilter_creators() => __pbn__prefilter_creators != null;
        public void Resetprefilter_creators() => __pbn__prefilter_creators = null;
        private bool? __pbn__prefilter_creators;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQuery_SearchSuggestions_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CStoreQueryResultMetadata metadata { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<StoreItemID> ids { get; } = new global::System.Collections.Generic.List<StoreItemID>();

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<StoreItem> store_items { get; } = new global::System.Collections.Generic.List<StoreItem>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryFilters : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool released_only
        {
            get => __pbn__released_only.GetValueOrDefault();
            set => __pbn__released_only = value;
        }
        public bool ShouldSerializereleased_only() => __pbn__released_only != null;
        public void Resetreleased_only() => __pbn__released_only = null;
        private bool? __pbn__released_only;

        [global::ProtoBuf.ProtoMember(2)]
        public bool coming_soon_only
        {
            get => __pbn__coming_soon_only.GetValueOrDefault();
            set => __pbn__coming_soon_only = value;
        }
        public bool ShouldSerializecoming_soon_only() => __pbn__coming_soon_only != null;
        public void Resetcoming_soon_only() => __pbn__coming_soon_only = null;
        private bool? __pbn__coming_soon_only;

        [global::ProtoBuf.ProtoMember(3)]
        public CStoreQueryFilters_TypeFilters type_filters { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<CStoreQueryFilters_TagFilter> tagids_must_match { get; } = new global::System.Collections.Generic.List<CStoreQueryFilters_TagFilter>();

        [global::ProtoBuf.ProtoMember(11)]
        public global::System.Collections.Generic.List<int> tagids_exclude { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(12)]
        public CStoreQueryFilters_PriceFilters price_filters { get; set; }

        [global::ProtoBuf.ProtoMember(15)]
        public global::System.Collections.Generic.List<int> content_descriptors_must_match { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(16)]
        public global::System.Collections.Generic.List<int> content_descriptors_excluded { get; } = new global::System.Collections.Generic.List<int>();

        [global::ProtoBuf.ProtoMember(40)]
        public int regional_top_n_sellers
        {
            get => __pbn__regional_top_n_sellers.GetValueOrDefault();
            set => __pbn__regional_top_n_sellers = value;
        }
        public bool ShouldSerializeregional_top_n_sellers() => __pbn__regional_top_n_sellers != null;
        public void Resetregional_top_n_sellers() => __pbn__regional_top_n_sellers = null;
        private int? __pbn__regional_top_n_sellers;

        [global::ProtoBuf.ProtoMember(41)]
        public int global_top_n_sellers
        {
            get => __pbn__global_top_n_sellers.GetValueOrDefault();
            set => __pbn__global_top_n_sellers = value;
        }
        public bool ShouldSerializeglobal_top_n_sellers() => __pbn__global_top_n_sellers != null;
        public void Resetglobal_top_n_sellers() => __pbn__global_top_n_sellers = null;
        private int? __pbn__global_top_n_sellers;

        [global::ProtoBuf.ProtoMember(42)]
        public int regional_long_term_top_n_sellers
        {
            get => __pbn__regional_long_term_top_n_sellers.GetValueOrDefault();
            set => __pbn__regional_long_term_top_n_sellers = value;
        }
        public bool ShouldSerializeregional_long_term_top_n_sellers() => __pbn__regional_long_term_top_n_sellers != null;
        public void Resetregional_long_term_top_n_sellers() => __pbn__regional_long_term_top_n_sellers = null;
        private int? __pbn__regional_long_term_top_n_sellers;

        [global::ProtoBuf.ProtoMember(43)]
        public int global_long_term_top_n_sellers
        {
            get => __pbn__global_long_term_top_n_sellers.GetValueOrDefault();
            set => __pbn__global_long_term_top_n_sellers = value;
        }
        public bool ShouldSerializeglobal_long_term_top_n_sellers() => __pbn__global_long_term_top_n_sellers != null;
        public void Resetglobal_long_term_top_n_sellers() => __pbn__global_long_term_top_n_sellers = null;
        private int? __pbn__global_long_term_top_n_sellers;

        [global::ProtoBuf.ProtoMember(44)]
        public CStorePageFilter store_page_filter { get; set; }

        [global::ProtoBuf.ProtoMember(45)]
        public global::System.Collections.Generic.List<uint> parent_appids { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryFilters_PriceFilters : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool only_free_items
        {
            get => __pbn__only_free_items.GetValueOrDefault();
            set => __pbn__only_free_items = value;
        }
        public bool ShouldSerializeonly_free_items() => __pbn__only_free_items != null;
        public void Resetonly_free_items() => __pbn__only_free_items = null;
        private bool? __pbn__only_free_items;

        [global::ProtoBuf.ProtoMember(2)]
        public bool exclude_free_items
        {
            get => __pbn__exclude_free_items.GetValueOrDefault();
            set => __pbn__exclude_free_items = value;
        }
        public bool ShouldSerializeexclude_free_items() => __pbn__exclude_free_items != null;
        public void Resetexclude_free_items() => __pbn__exclude_free_items = null;
        private bool? __pbn__exclude_free_items;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryFilters_TagFilter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<int> tagids { get; } = new global::System.Collections.Generic.List<int>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryFilters_TypeFilters : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool include_apps
        {
            get => __pbn__include_apps.GetValueOrDefault();
            set => __pbn__include_apps = value;
        }
        public bool ShouldSerializeinclude_apps() => __pbn__include_apps != null;
        public void Resetinclude_apps() => __pbn__include_apps = null;
        private bool? __pbn__include_apps;

        [global::ProtoBuf.ProtoMember(2)]
        public bool include_packages
        {
            get => __pbn__include_packages.GetValueOrDefault();
            set => __pbn__include_packages = value;
        }
        public bool ShouldSerializeinclude_packages() => __pbn__include_packages != null;
        public void Resetinclude_packages() => __pbn__include_packages = null;
        private bool? __pbn__include_packages;

        [global::ProtoBuf.ProtoMember(3)]
        public bool include_bundles
        {
            get => __pbn__include_bundles.GetValueOrDefault();
            set => __pbn__include_bundles = value;
        }
        public bool ShouldSerializeinclude_bundles() => __pbn__include_bundles != null;
        public void Resetinclude_bundles() => __pbn__include_bundles = null;
        private bool? __pbn__include_bundles;

        [global::ProtoBuf.ProtoMember(10)]
        public bool include_games
        {
            get => __pbn__include_games.GetValueOrDefault();
            set => __pbn__include_games = value;
        }
        public bool ShouldSerializeinclude_games() => __pbn__include_games != null;
        public void Resetinclude_games() => __pbn__include_games = null;
        private bool? __pbn__include_games;

        [global::ProtoBuf.ProtoMember(11)]
        public bool include_demos
        {
            get => __pbn__include_demos.GetValueOrDefault();
            set => __pbn__include_demos = value;
        }
        public bool ShouldSerializeinclude_demos() => __pbn__include_demos != null;
        public void Resetinclude_demos() => __pbn__include_demos = null;
        private bool? __pbn__include_demos;

        [global::ProtoBuf.ProtoMember(12)]
        public bool include_mods
        {
            get => __pbn__include_mods.GetValueOrDefault();
            set => __pbn__include_mods = value;
        }
        public bool ShouldSerializeinclude_mods() => __pbn__include_mods != null;
        public void Resetinclude_mods() => __pbn__include_mods = null;
        private bool? __pbn__include_mods;

        [global::ProtoBuf.ProtoMember(13)]
        public bool include_dlc
        {
            get => __pbn__include_dlc.GetValueOrDefault();
            set => __pbn__include_dlc = value;
        }
        public bool ShouldSerializeinclude_dlc() => __pbn__include_dlc != null;
        public void Resetinclude_dlc() => __pbn__include_dlc = null;
        private bool? __pbn__include_dlc;

        [global::ProtoBuf.ProtoMember(14)]
        public bool include_software
        {
            get => __pbn__include_software.GetValueOrDefault();
            set => __pbn__include_software = value;
        }
        public bool ShouldSerializeinclude_software() => __pbn__include_software != null;
        public void Resetinclude_software() => __pbn__include_software = null;
        private bool? __pbn__include_software;

        [global::ProtoBuf.ProtoMember(15)]
        public bool include_video
        {
            get => __pbn__include_video.GetValueOrDefault();
            set => __pbn__include_video = value;
        }
        public bool ShouldSerializeinclude_video() => __pbn__include_video != null;
        public void Resetinclude_video() => __pbn__include_video = null;
        private bool? __pbn__include_video;

        [global::ProtoBuf.ProtoMember(16)]
        public bool include_hardware
        {
            get => __pbn__include_hardware.GetValueOrDefault();
            set => __pbn__include_hardware = value;
        }
        public bool ShouldSerializeinclude_hardware() => __pbn__include_hardware != null;
        public void Resetinclude_hardware() => __pbn__include_hardware = null;
        private bool? __pbn__include_hardware;

        [global::ProtoBuf.ProtoMember(17)]
        public bool include_series
        {
            get => __pbn__include_series.GetValueOrDefault();
            set => __pbn__include_series = value;
        }
        public bool ShouldSerializeinclude_series() => __pbn__include_series != null;
        public void Resetinclude_series() => __pbn__include_series = null;
        private bool? __pbn__include_series;

        [global::ProtoBuf.ProtoMember(18)]
        public bool include_music
        {
            get => __pbn__include_music.GetValueOrDefault();
            set => __pbn__include_music = value;
        }
        public bool ShouldSerializeinclude_music() => __pbn__include_music != null;
        public void Resetinclude_music() => __pbn__include_music = null;
        private bool? __pbn__include_music;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryParams : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int start
        {
            get => __pbn__start ?? 0;
            set => __pbn__start = value;
        }
        public bool ShouldSerializestart() => __pbn__start != null;
        public void Resetstart() => __pbn__start = null;
        private int? __pbn__start;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10)]
        public int count
        {
            get => __pbn__count ?? 10;
            set => __pbn__count = value;
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private int? __pbn__count;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int sort
        {
            get => __pbn__sort ?? 0;
            set => __pbn__sort = value;
        }
        public bool ShouldSerializesort() => __pbn__sort != null;
        public void Resetsort() => __pbn__sort = null;
        private int? __pbn__sort;

        [global::ProtoBuf.ProtoMember(20)]
        public CStoreQueryFilters filters { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryPerResultMetadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public StoreItemID id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double score
        {
            get => __pbn__score.GetValueOrDefault();
            set => __pbn__score = value;
        }
        public bool ShouldSerializescore() => __pbn__score != null;
        public void Resetscore() => __pbn__score = null;
        private double? __pbn__score;

        [global::ProtoBuf.ProtoMember(3)]
        public bool spellcheck_generated_result
        {
            get => __pbn__spellcheck_generated_result.GetValueOrDefault();
            set => __pbn__spellcheck_generated_result = value;
        }
        public bool ShouldSerializespellcheck_generated_result() => __pbn__spellcheck_generated_result != null;
        public void Resetspellcheck_generated_result() => __pbn__spellcheck_generated_result = null;
        private bool? __pbn__spellcheck_generated_result;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStoreQueryResultMetadata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int total_matching_records
        {
            get => __pbn__total_matching_records.GetValueOrDefault();
            set => __pbn__total_matching_records = value;
        }
        public bool ShouldSerializetotal_matching_records() => __pbn__total_matching_records != null;
        public void Resettotal_matching_records() => __pbn__total_matching_records = null;
        private int? __pbn__total_matching_records;

        [global::ProtoBuf.ProtoMember(2)]
        public int start
        {
            get => __pbn__start.GetValueOrDefault();
            set => __pbn__start = value;
        }
        public bool ShouldSerializestart() => __pbn__start != null;
        public void Resetstart() => __pbn__start = null;
        private int? __pbn__start;

        [global::ProtoBuf.ProtoMember(3)]
        public int count
        {
            get => __pbn__count.GetValueOrDefault();
            set => __pbn__count = value;
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private int? __pbn__count;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<CStoreQueryPerResultMetadata> per_result_metadata { get; } = new global::System.Collections.Generic.List<CStoreQueryPerResultMetadata>();

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<string> spellcheck_suggestions { get; } = new global::System.Collections.Generic.List<string>();

    }

    public class StoreQuery : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "StoreQuery";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CStoreQuery_GetItemsByUserRecommendedTags_Response>> GetItemsByUserRecommendedTags( CStoreQuery_GetItemsByUserRecommendedTags_Request request )
        {
            return UnifiedMessages.SendMessage<CStoreQuery_GetItemsByUserRecommendedTags_Request, CStoreQuery_GetItemsByUserRecommendedTags_Response>( "StoreQuery.GetItemsByUserRecommendedTags#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CStoreQuery_Query_Response>> Query( CStoreQuery_Query_Request request )
        {
            return UnifiedMessages.SendMessage<CStoreQuery_Query_Request, CStoreQuery_Query_Response>( "StoreQuery.Query#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CStoreQuery_SearchSuggestions_Response>> SearchSuggestions( CStoreQuery_SearchSuggestions_Request request )
        {
            return UnifiedMessages.SendMessage<CStoreQuery_SearchSuggestions_Request, CStoreQuery_SearchSuggestions_Response>( "StoreQuery.SearchSuggestions#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "GetItemsByUserRecommendedTags":
                    UnifiedMessages.HandleResponseMsg<CStoreQuery_GetItemsByUserRecommendedTags_Response>( packetMsg );
                    break;
                case "Query":
                    UnifiedMessages.HandleResponseMsg<CStoreQuery_Query_Response>( packetMsg );
                    break;
                case "SearchSuggestions":
                    UnifiedMessages.HandleResponseMsg<CStoreQuery_SearchSuggestions_Response>( packetMsg );
                    break;
            }
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
