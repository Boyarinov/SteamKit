// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: service_accountcart.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.WebUI.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class AccountCartContents : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<AccountCartLineItem> line_items { get; } = new global::System.Collections.Generic.List<AccountCartLineItem>();

        [global::ProtoBuf.ProtoMember(2)]
        public CartAmount subtotal { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public bool is_valid
        {
            get => __pbn__is_valid.GetValueOrDefault();
            set => __pbn__is_valid = value;
        }
        public bool ShouldSerializeis_valid() => __pbn__is_valid != null;
        public void Resetis_valid() => __pbn__is_valid = null;
        private bool? __pbn__is_valid;

        [global::ProtoBuf.ProtoMember(4)]
        public AccountCartValidationDetails validation_details { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AccountCartLineItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong line_item_id
        {
            get => __pbn__line_item_id.GetValueOrDefault();
            set => __pbn__line_item_id = value;
        }
        public bool ShouldSerializeline_item_id() => __pbn__line_item_id != null;
        public void Resetline_item_id() => __pbn__line_item_id = null;
        private ulong? __pbn__line_item_id;

        [global::ProtoBuf.ProtoMember(2)]
        public int type
        {
            get => __pbn__type.GetValueOrDefault();
            set => __pbn__type = value;
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private int? __pbn__type;

        [global::ProtoBuf.ProtoMember(3)]
        public uint packageid
        {
            get => __pbn__packageid.GetValueOrDefault();
            set => __pbn__packageid = value;
        }
        public bool ShouldSerializepackageid() => __pbn__packageid != null;
        public void Resetpackageid() => __pbn__packageid = null;
        private uint? __pbn__packageid;

        [global::ProtoBuf.ProtoMember(4)]
        public uint bundleid
        {
            get => __pbn__bundleid.GetValueOrDefault();
            set => __pbn__bundleid = value;
        }
        public bool ShouldSerializebundleid() => __pbn__bundleid != null;
        public void Resetbundleid() => __pbn__bundleid = null;
        private uint? __pbn__bundleid;

        [global::ProtoBuf.ProtoMember(8)]
        public bool is_valid
        {
            get => __pbn__is_valid.GetValueOrDefault();
            set => __pbn__is_valid = value;
        }
        public bool ShouldSerializeis_valid() => __pbn__is_valid != null;
        public void Resetis_valid() => __pbn__is_valid = null;
        private bool? __pbn__is_valid;

        [global::ProtoBuf.ProtoMember(9)]
        public AccountCartValidationDetails validation_details { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public uint time_added
        {
            get => __pbn__time_added.GetValueOrDefault();
            set => __pbn__time_added = value;
        }
        public bool ShouldSerializetime_added() => __pbn__time_added != null;
        public void Resettime_added() => __pbn__time_added = null;
        private uint? __pbn__time_added;

        [global::ProtoBuf.ProtoMember(11)]
        public CartAmount price_when_added { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public CartGiftInfo gift_info { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public AccountCartLineItemFlags flags { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public ulong gidcoupon_applied
        {
            get => __pbn__gidcoupon_applied.GetValueOrDefault();
            set => __pbn__gidcoupon_applied = value;
        }
        public bool ShouldSerializegidcoupon_applied() => __pbn__gidcoupon_applied != null;
        public void Resetgidcoupon_applied() => __pbn__gidcoupon_applied = null;
        private ulong? __pbn__gidcoupon_applied;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AccountCartLineItemFlags : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool is_gift
        {
            get => __pbn__is_gift.GetValueOrDefault();
            set => __pbn__is_gift = value;
        }
        public bool ShouldSerializeis_gift() => __pbn__is_gift != null;
        public void Resetis_gift() => __pbn__is_gift = null;
        private bool? __pbn__is_gift;

        [global::ProtoBuf.ProtoMember(2)]
        public bool is_private
        {
            get => __pbn__is_private.GetValueOrDefault();
            set => __pbn__is_private = value;
        }
        public bool ShouldSerializeis_private() => __pbn__is_private != null;
        public void Resetis_private() => __pbn__is_private = null;
        private bool? __pbn__is_private;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AccountCartValidationDetails : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int validation_failure
        {
            get => __pbn__validation_failure ?? 0;
            set => __pbn__validation_failure = value;
        }
        public bool ShouldSerializevalidation_failure() => __pbn__validation_failure != null;
        public void Resetvalidation_failure() => __pbn__validation_failure = null;
        private int? __pbn__validation_failure;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_AddItemsToCart_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_country
        {
            get => __pbn__user_country ?? "";
            set => __pbn__user_country = value;
        }
        public bool ShouldSerializeuser_country() => __pbn__user_country != null;
        public void Resetuser_country() => __pbn__user_country = null;
        private string __pbn__user_country;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CAccountCart_AddItemsToCart_Request_ItemToAdd> items { get; } = new global::System.Collections.Generic.List<CAccountCart_AddItemsToCart_Request_ItemToAdd>();

        [global::ProtoBuf.ProtoMember(3)]
        public CUserInterface_NavData navdata { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_AddItemsToCart_Request_ItemToAdd : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint packageid
        {
            get => __pbn__packageid.GetValueOrDefault();
            set => __pbn__packageid = value;
        }
        public bool ShouldSerializepackageid() => __pbn__packageid != null;
        public void Resetpackageid() => __pbn__packageid = null;
        private uint? __pbn__packageid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint bundleid
        {
            get => __pbn__bundleid.GetValueOrDefault();
            set => __pbn__bundleid = value;
        }
        public bool ShouldSerializebundleid() => __pbn__bundleid != null;
        public void Resetbundleid() => __pbn__bundleid = null;
        private uint? __pbn__bundleid;

        [global::ProtoBuf.ProtoMember(10)]
        public CartGiftInfo gift_info { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public AccountCartLineItemFlags flags { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_AddItemsToCart_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ulong> line_item_ids { get; } = new global::System.Collections.Generic.List<ulong>();

        [global::ProtoBuf.ProtoMember(2)]
        public AccountCartContents cart { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<uint> replaced_packages { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(4)]
        public ulong existing_billing_agreementid
        {
            get => __pbn__existing_billing_agreementid.GetValueOrDefault();
            set => __pbn__existing_billing_agreementid = value;
        }
        public bool ShouldSerializeexisting_billing_agreementid() => __pbn__existing_billing_agreementid != null;
        public void Resetexisting_billing_agreementid() => __pbn__existing_billing_agreementid = null;
        private ulong? __pbn__existing_billing_agreementid;

        [global::ProtoBuf.ProtoMember(5)]
        public uint new_billing_agreement_recurring_packageid
        {
            get => __pbn__new_billing_agreement_recurring_packageid.GetValueOrDefault();
            set => __pbn__new_billing_agreement_recurring_packageid = value;
        }
        public bool ShouldSerializenew_billing_agreement_recurring_packageid() => __pbn__new_billing_agreement_recurring_packageid != null;
        public void Resetnew_billing_agreement_recurring_packageid() => __pbn__new_billing_agreement_recurring_packageid = null;
        private uint? __pbn__new_billing_agreement_recurring_packageid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_DeleteCart_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_DeleteCart_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_GetCart_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_country
        {
            get => __pbn__user_country ?? "";
            set => __pbn__user_country = value;
        }
        public bool ShouldSerializeuser_country() => __pbn__user_country != null;
        public void Resetuser_country() => __pbn__user_country = null;
        private string __pbn__user_country;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_GetCart_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public AccountCartContents cart { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_GetRelevantCoupons_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint language
        {
            get => __pbn__language.GetValueOrDefault();
            set => __pbn__language = value;
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private uint? __pbn__language;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_GetRelevantCoupons_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CAccountCart_GetRelevantCoupons_Response_LineItemCoupons> line_items { get; } = new global::System.Collections.Generic.List<CAccountCart_GetRelevantCoupons_Response_LineItemCoupons>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_GetRelevantCoupons_Response_LineItemCoupons : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong line_item_id
        {
            get => __pbn__line_item_id.GetValueOrDefault();
            set => __pbn__line_item_id = value;
        }
        public bool ShouldSerializeline_item_id() => __pbn__line_item_id != null;
        public void Resetline_item_id() => __pbn__line_item_id = null;
        private ulong? __pbn__line_item_id;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CartCoupon> coupons { get; } = new global::System.Collections.Generic.List<CartCoupon>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_MergeShoppingCartContents_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong gidshoppingcart
        {
            get => __pbn__gidshoppingcart.GetValueOrDefault();
            set => __pbn__gidshoppingcart = value;
        }
        public bool ShouldSerializegidshoppingcart() => __pbn__gidshoppingcart != null;
        public void Resetgidshoppingcart() => __pbn__gidshoppingcart = null;
        private ulong? __pbn__gidshoppingcart;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_country
        {
            get => __pbn__user_country ?? "";
            set => __pbn__user_country = value;
        }
        public bool ShouldSerializeuser_country() => __pbn__user_country != null;
        public void Resetuser_country() => __pbn__user_country = null;
        private string __pbn__user_country;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_MergeShoppingCartContents_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public AccountCartContents cart { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_ModifyLineItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong line_item_id
        {
            get => __pbn__line_item_id.GetValueOrDefault();
            set => __pbn__line_item_id = value;
        }
        public bool ShouldSerializeline_item_id() => __pbn__line_item_id != null;
        public void Resetline_item_id() => __pbn__line_item_id = null;
        private ulong? __pbn__line_item_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_country
        {
            get => __pbn__user_country ?? "";
            set => __pbn__user_country = value;
        }
        public bool ShouldSerializeuser_country() => __pbn__user_country != null;
        public void Resetuser_country() => __pbn__user_country = null;
        private string __pbn__user_country;

        [global::ProtoBuf.ProtoMember(10)]
        public CartGiftInfo gift_info { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public AccountCartLineItemFlags flags { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public ulong apply_gidcoupon
        {
            get => __pbn__apply_gidcoupon.GetValueOrDefault();
            set => __pbn__apply_gidcoupon = value;
        }
        public bool ShouldSerializeapply_gidcoupon() => __pbn__apply_gidcoupon != null;
        public void Resetapply_gidcoupon() => __pbn__apply_gidcoupon = null;
        private ulong? __pbn__apply_gidcoupon;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_ModifyLineItem_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public AccountCartContents cart { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_RemoveItemFromCart_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong line_item_id
        {
            get => __pbn__line_item_id.GetValueOrDefault();
            set => __pbn__line_item_id = value;
        }
        public bool ShouldSerializeline_item_id() => __pbn__line_item_id != null;
        public void Resetline_item_id() => __pbn__line_item_id = null;
        private ulong? __pbn__line_item_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_country
        {
            get => __pbn__user_country ?? "";
            set => __pbn__user_country = value;
        }
        public bool ShouldSerializeuser_country() => __pbn__user_country != null;
        public void Resetuser_country() => __pbn__user_country = null;
        private string __pbn__user_country;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountCart_RemoveItemFromCart_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public AccountCartContents cart { get; set; }

    }

    public class AccountCart : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "AccountCart";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_AddItemsToCart_Response>> AddItemsToCart( CAccountCart_AddItemsToCart_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_AddItemsToCart_Request, CAccountCart_AddItemsToCart_Response>( "AccountCart.AddItemsToCart#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_DeleteCart_Response>> DeleteCart( CAccountCart_DeleteCart_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_DeleteCart_Request, CAccountCart_DeleteCart_Response>( "AccountCart.DeleteCart#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_GetCart_Response>> GetCart( CAccountCart_GetCart_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_GetCart_Request, CAccountCart_GetCart_Response>( "AccountCart.GetCart#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_GetRelevantCoupons_Response>> GetRelevantCoupons( CAccountCart_GetRelevantCoupons_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_GetRelevantCoupons_Request, CAccountCart_GetRelevantCoupons_Response>( "AccountCart.GetRelevantCoupons#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_MergeShoppingCartContents_Response>> MergeShoppingCartContents( CAccountCart_MergeShoppingCartContents_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_MergeShoppingCartContents_Request, CAccountCart_MergeShoppingCartContents_Response>( "AccountCart.MergeShoppingCartContents#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_ModifyLineItem_Response>> ModifyLineItem( CAccountCart_ModifyLineItem_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_ModifyLineItem_Request, CAccountCart_ModifyLineItem_Response>( "AccountCart.ModifyLineItem#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CAccountCart_RemoveItemFromCart_Response>> RemoveItemFromCart( CAccountCart_RemoveItemFromCart_Request request )
        {
            return UnifiedMessages.SendMessage<CAccountCart_RemoveItemFromCart_Request, CAccountCart_RemoveItemFromCart_Response>( "AccountCart.RemoveItemFromCart#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "AddItemsToCart":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_AddItemsToCart_Response>( packetMsg );
                    break;
                case "DeleteCart":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_DeleteCart_Response>( packetMsg );
                    break;
                case "GetCart":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_GetCart_Response>( packetMsg );
                    break;
                case "GetRelevantCoupons":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_GetRelevantCoupons_Response>( packetMsg );
                    break;
                case "MergeShoppingCartContents":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_MergeShoppingCartContents_Response>( packetMsg );
                    break;
                case "ModifyLineItem":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_ModifyLineItem_Response>( packetMsg );
                    break;
                case "RemoveItemFromCart":
                    UnifiedMessages.HandleResponseMsg<CAccountCart_RemoveItemFromCart_Response>( packetMsg );
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
