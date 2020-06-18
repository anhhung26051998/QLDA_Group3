
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils
{
    public class SystemParam
    {
        //CarRectEntities cnns = new CarRectEntities();
        //public const string vnp_Return_url = "http://api.carrect.vn/VnPay/Index";
        //public const string vnpay_api_url = "http://api.carrect.vn/api/Service/vnp_ipn";
        public const string vnp_Return_url = "http://winds.hopto.org/VnPay/Index";
        public const string vnpay_api_url = "http://winds.hopto.org/api/Service/vnp_ipn";
        //public const string vnp_Return_url = "http://localhost:11111/VnPay/Index";
        //public const string vnpay_api_url = "http://localhost:11111/api/Service/vnp_ipn";
        public const int MAX_RETRY_NOTI = 3;
        public const string washer_success = "washer://success/";
        public const string cusmtomer_success = "customer://success/";
        public const string washer_failed = "washer://failed/";
        public const string cusmtomer_failed = "customer://failed/";


        public const string vnp_Return_Rawurl = "/api/Service/vnp_return";
        public const string vnpay_api_Rawurl = "/api/Service/vnp_ipn";

        public const string vnp_Url = "http://sandbox.vnpayment.vn/paymentv2/vpcpay.html";
        public const string vnp_TmnCode = "EVERGL01";
        public const string vnp_HashSecret = "LRKPTTMKJNEKREDJVXCKGGRXYTJBPVPA";

        public const string URL_ONESIGNAL = "https://onesignal.com/api/v1/notifications";
        public const string URL_BASE_https = "Basic ://onesignal.com/api/v1/notifications";
        public const string Authorization = "Basic :ZGZlZmEwNmItNmUxMi00Y2NjLWJmOGUtMWFiMGQxYzU4NDY5";

        public const string vnp_CodeSucces = "00";

        public const double LON_DEFAUL = 105.7930512;
        public const double LAT_DEFAUL = 20.9977337;
        public const string PASS_DEFAUL = "windsoft@123";
        public const string HOST_DEFAUL = "smtp.gmail.com";
        public const string EMAIL_CONFIG = "gasvietsp @gmail.com";
        public const string PASS_CONFIG = "tktjjucoxcosivsc";
        public const string PASS_EMAIL = "windsoft123456@";

        // check box status
        public const int CHECKBOX = 1;
        public const int UNCHECKBOX = 0;
        public const int CHECKALL = 2;
        public const int UNCHECKALL = 3;
        //public const int TIME_DELAY = cnn.Configs.Where(u =>u.Key.Equals("")).Select(u =>u.Value).FirstOrDefault();
        public const int MIN_MONEY_SENNOTI = 1000;
        //public const int DISTANCE_DEFAULT = 5;
        public const int CUSTOMER_DEFAULT = 3;


        public const int CONFIG_TIME = 5;
        public const int ROLL_ADMIN = 1;
        public const int ROLL_CUSTOMER = 0;
        public const int POINT_START = 9;
        //public const int ROLL_ADMIN = 1;
        public const int TYPE_LOGIN_PHONE = 3;
        public const int TYPE_LOGIN_FACE = 1;
        public const int TYPE_LOGIN_GOOGLE = 2;

        public const int NO_NEED_UPDATE = 0;
        public const int NEED_UPDATE = 1;

        public const string CONVERT_DATETIME = "dd/MM/yyyy";
        public const string CONVERT_DATETIME_HAVE_HOUR = "HH:mm dd/MM/yyyy";
        public const string CONVERT_DATETIME_HOUR = "HH:mm";
        public const int MAX_ROW_IN_LIST = 30;
        public const int ACTIVE = 1;
        public const int INACTIVE = 0;
        public const int DEACTIVE = 2;

        public const int RETURN_TRUE = 1;
        public const int RETURN_FALSE = 0;
        public const int ACTIVE_FALSE = 0;
        public const int COUNT_NULL = 0;
        public const int DELETE_REQUEST_FAIL = 2;
        public const int CATEGORY_PRODUCT = 11;

        public const int TYPE_IMAGE = 1;
        public const int TYPE_VIDEO = 2;
        // thanh cong
        public const int SUCCESS_CODE = 200;
        // thanh cong
        public const int STATUS_CHANGED = 7749;
        // sai mk
        public const int ERROR_PASS_API = 403;
        // loi quy trinh
        public const int PROCESS_ERROR = 500;
        public const int PERMISSION_DENIED = 101;
        public const int FAIL = 501;
        public const int ERROR = 0;
        public const int SUCCESS = 1;

        //Type language Vietamese
        public const int LANGUAGE_VIETNAMESE = 1;
        //Type language english
        public const int LANGUAGE_ENGLISH = 2;

        // khong duoc phep
        public const int NOT_FOUND = 404;
        // khong thay du lieu
        public const int DATA_NOT_FOUND = 400;
        // khong duoc phep
        public const int UNAUTHORIZED = 401;

        public const int STATUS_RUNNING = 1;
        public const int STATUS_REQUEST_WAITING = 0;
        public const int STATUS_REQUEST_SUCCESS = 1;
        public const int STATUS_REQUEST_CANCEl = 2;
        public const int STATUS_REQUEST_DELETE = 3;
        // Type đổi quà
        public const int TYPE_POINT_SAVE = 1;
        public const int TYPE_RECEIVE_ORDER = 2;
        //public const int TYPE_POINT_RECEIVE = 3;
        //public const int TYPE_POINT_RECEIVE_GIFT =4;
        //public const int TYPE_ADD_POINT =5;
        //public const int TYPE_CARD =6;

        public const int SIZE_CODE = 8;
        public const int MIN_NUMBER = 100000;
        public const int MAX_NUMBER = 999999;


        // Status warranty 
        public const int W_STATUS_ACTIVE = 1;
        public const int W_STATUS_NO_ACTIVE = 2;
        public const int W_STATUS_ERROR = 3;

        // cách kiểu tích điểm
        public const int WARRANTY = 2;
        public const int PRODUCT = 1;

        //
        public const int MESS_BY_CUS = 1;
        public const int MESS_BY_ADMIN = 2;
        //
        public const int NEWS_TYPE_ADVERTISEMENT = 1;
        public const int NEWS_TYPE_EVENT = 2;
        public const int NEWS_TYPE_NEWS = 3;
        public const int NEWS_TYPE_PRODUCT = 4;
        public const int NEWS_TYPE_PROMOTION = 5;
        //
        public const string COMMENT_HISTORY_ADD_POINT = "Tích điểm";
        // link check access Token
        public const string LINK_URL_FACEBOOK = "https://graph.facebook.com/me?fields=name,picture.height(960).width(960)&access_token=";
        public const string LINK_URL_GOOGLE_MAIL = "https://www.googleapis.com/plus/v1/people/me?access_token=";
        // Telecom
        public const int MAX_TELECOM = 4;
        public const string URL_VIETTEL = "https://upload.wikimedia.org/wikipedia/vi/thumb/e/e8/Logo_Viettel.svg/800px-Logo_Viettel.svg.png";
        public const string URL_MOBIPHONE = "https://upload.wikimedia.org/wikipedia/commons/d/de/Mobifone.png";
        public const string URL_VINAPHONE = "https://lozimom.com/wp-content/uploads/2017/04/vinaphone-logo.png";
        public const string URL_VIETNAMMOBILE = "https://upload.wikimedia.org/wikipedia/vi/thumb/a/a8/Vietnamobile_Logo.svg/1280px-Vietnamobile_Logo.svg.png";
        public const int TELECOM_TYPE_GIFT = 0;
        public const int TYPE_VIETTEL = 1;
        public const int TYPE_MOBIPHONE = 2;
        public const int TYPE_VINAPHONE = 3;
        public const int TYPE_VIETNAMMOBILE = 4;
        public const string TYPE_VIETTEL_STRING = "Viettel";
        public const string TYPE_MOBIPHONE_STRING = "Mobiphone";
        public const string TYPE_VINAPHONE_STRING = "Vinaphone";
        public const string TYPE_VIETNAMMOBILE_STRING = "VietnamMobile";
        public const string URL_FIRST = "https://graph.facebook.com/";
        public const string URL_LAST = "/picture?type=large&redirect=true&width=250&height=250";
        public const int STATUS_PRODUCT_ACTIVE = 1;
        public const int STATUS_PRODUCT_NO_ACTIVE = 2;
        public const string STATUS_PRODUCT_ACTIVE_STRING = "Đã sử dụng";
        public const string STATUS_PRODUCT_NO_ACTIVE_STRING = "Chưa sử dụng";

        public const int STATUS_REQUEST_PENDING = 0;
        public const int STATUS_REQUEST_ACCEPTED = 1;
        public const int STATUS_REQUEST_CANCEL = 2;
        public const string STATUS_REQUEST_PENDING_STRING = "Chờ xác nhận";
        public const string STATUS_REQUEST_ACCEPTED_STRING = "Đã xác nhận";
        public const string STATUS_REQUEST_CANCEL_STRING = "Hủy";

        public const int TYPE_REQUEST_GIFT = 1;
        public const int TYPE_REQUEST_VOUCHER = 2;
        public const int TYPE_REQUEST_CARD = 3;

        public const string TYPE_REQUEST_GIFT_STRING = "Quà tặng";
        public const string TYPE_REQUEST_VOUCHER_STRING = "Voucher";
        public const string TYPE_REQUEST_CARD_STRING = "Thẻ cào";

        public const int TYPE_GIFT_GIFT = 1;
        public const int TYPE_GIFT_VOUCHER = 2;
        public const int TYPE_GIFT_CARD = 3;

        public const int STATUS_GIFT_ACTIVE = 1;
        public const int STATUS_GIFT_PAUSE = 0;
        public const int STATUS_GIFT_CANCEL_AND_ADD = 2;
        public const int STATUS_GIFT_CANCEL = 3;

        public const int NO_ACTIVE_DELETE = 0;
        public const int MAX_ROW_IN_LIST_WEB = 20;
        public const bool BOOLEAN_TRUE = true;
        public const bool BOOLEAN_FALSE = false;
        public const int DUPLICATE_NAME = 2;

        public const int QRCODE_TYPE_PRODUCT = 1;
        public const int QRCODE_TYPE_WARRANTY = 2;

        public const int STATUS_CARD_ACTIVE = 1;
        public const int STATUS_CARD_NO_ACTIVE = 2;
        public const int ERROR_DATE = 3;



        public const float KeyA = 11;
        public const float KeyB = 87;
        public const float KeyC = 48;
        public const string ICON_DEFAULT = "https://img.icons8.com/color/240/000000/google-alerts.png";
        public const string ICON_SUB_POINT = "https://img.icons8.com/color/240/000000/google-alerts.png";


        public const int TYPE_NOTI_NEW_ORDER = 0;
        public const int TYPE_NOTI_CONFIRM_ORDER = 1;
        public const int TYPE_NOTI_ORDER_CUSSCESS = 2;
        public const int TYPE_NOTI_ORDER_CANCEL = 3;
        public const int TYPE_NOTI_ORDER_ADMIN = 4;

        public const int HAVE_A_NEW_ORDER = 1;
        public const int AGENT_DEFAULT_TYPE = -1;
        public const int HAVE_A_NEW_NOTI = 2;
        public const int HAVE_A_NEW_NEWS = 3;

        public const int TYPE_ADS = 1;
        public const int TYPE_EVENT = 2;
        public const int TYPE_NEWS = 3;
        public const int TYPE_PRODUCT = 4;
        public const int TYPE_PROMOTION = 5;
        public const int TYPE_PRICE_QUOTE = 6;

        public const string TYPE_ADS_STRING = "Advertisement";
        public const string TYPE_EVENT_STRING = "Event";
        public const string TYPE_NEWS_STRING = "News";
        public const string TYPE_PRODUCT_STRING = "Products";
        public const string TYPE_PROMOTION_STRING = "Promotion";
        public const string TYPE_PRICE_QUOTE_STRING = "Price quote";


        public const int PARENT_NEWS_PRODUCT = 11;

        public const int TYPE_SEND_CUSTOMER = 2;
        public const int TYPE_SEND_AGENCY = 1;
        public const int TYPE_SEND_ALL = 0;

        public const int STATUS_COUPONS_TYPE_EXPIRED = 1;
        public const int STATUS_COUPONS_TYPE_UNEXPIRED = 0;

        public const int STATUS_COUPONS_PERCENT = 1;
        public const int STATUS_COUPONS_DISCOUNT = 2;

        public const int STATUS_COUPONS_ACTIVE = 1;
        public const int STATUS_COUPONS_INACTIVE = 0;
        public const int STATUS_COUPONS_EXPIRED = 2;

        public const int STATUS_NEWS_ACTIVE = 1;
        public const int STATUS_NEWS_DRAFT = 0;
        public const int UPDATE_NEWS_DEFAULT = 1;
        public const int UPDATE_NEWS_POST = 0;
        public const int LENGTH_QR_HASH = 15;
        public const int EXISTING = 2;
        public const int CAN_NOT_DELETE = 2;
        public const int ROLE_USER_ORDER = 3;
        public const int ROLE_USER = 2;
        public const int ROLE_ADMIN = 1;
        public const int NOT_ADMIN = 3;
        public const int WRONG_PASSWORD = 2;
        public const int FAIL_LOGIN = 2;
        public const int TYPE_REQUEST_NOTIFY = 4;
        public const int TYPE_ORDER_NOTIFY = 7;

        public const string MAX_POINT_PER_DAY = "MaxPointPerDay";
        public const string MIN_POINT = "MinPoin";

        //Card
        public const string IMPORT_CARD_VIETTEL = "viettel";
        public const string IMPORT_CARD_MOBIPHONE = "mobi";
        public const string IMPORT_CARD_VINAPHONE = "vina";
        public const string IMPORT_CARD_VIETNAMOBILE = "vnmobile";
        public const int TELECOMTYPE_VIETTEL = 1;
        public const int TELECOMTYPE_MOBIPHONE = 2;
        public const int TELECOMTYPE_VINAPHONE = 3;
        public const int TELECOMTYPE_VIETNAMOBILE = 4;
        public const int ERROR_IMPORT_DUPLICATE = 0;
        //public const int NO_ACTIVE_CARD = 2;
        // status Order
        public const int ORDER_STATUS_WAITING = 0;
        public const int ORDER_STATUS_PROCESS = 1;
        public const int ORDER_STATUS_REFUSE = 2;
        // Status for all
        public const int STATUS_ACTIVE = 1;
        public const int STATUS_NO_ACTIVE = 0;

        // Not Found
        public const int PHONE_NOT_FOUND = -1;

        // ExcelFile Error
        public const int FILE_NOT_FOUND = -1;
        public const int FILE_DATA_DUPLICATE = 0;
        public const int FILE_IMPORT_SUCCESS = 1;
        public const int FILE_FORMAT_ERROR = -2;
        public const int FILE_EMPTY = -3;
        public const int IMPORT_ERROR = -4;
        public const int MIN_LENGTH_VALIDATE = -5;
        public const int DATA_ERROR = -6;

        // check Length Card
        public const int MAX_LENGTH_CODE = -7;
        public const int MAX_LENGTH_SERI = -8;
        public const int CODE_EQUALS_SERI = -9;

        // type MemberPointHistory
        public const int HISPOINT_TICH_DIEM = 1;
        public const int HISPOINT_TANG_DIEM = 2;
        public const int HISPOINT_DUOC_TANG_DIEM = 3;
        public const int HISPOINT_DOI_QUA = 4;
        public const int HISPOINT_HE_THONG_CONG_DIEM = 5;
        public const int HISPOINT_DOI_THE = 6;
        public const int HAVE_A_NEWS = 6;
        public const int CHANGE_MINUS_POINT_ITEM = 4;

        //
        public const int ACTIVE_AGENT = 1;

        public const int HISTORY_POINT_CANCEL_REQUEST = 7;


        public const string EXPO_NOTI = "https://exp.host/--/api/v2/push/send";

        public const string SUCCES_STR = "Thành công";
        public const string LANG = "lang";
        public const string VN = "vi";
        public const string EN = "en";

        public const int MINI_SECOND = 60;
    }

    public class Constant
    {
        public static int[] washerConstant = { 10, 13, 17, 19, 21 , 37 };
        public static int[] customerConstant = { 20, 24, 48, 49, 70 , 121 };

        //type image requite
        public const int IMAGE_BEFORE = 1;
        public const int IMAGE_AFTER = 2;
        // TYPE IMAGE Service
        public const int MAIN_IMAGE = 1;
        public const int ORTHER_IMAGE = 2;
        public const int THUMBNAIL_IMAGE = 3;

        //otp
        public const int OTP_TYPE_REGISTER = 1;
        public const int OTP_TYPE_FORGOT_PASS = 2;

        // wallet
        public const int WALLET_WITHDRAW = 2;
        public const int WALLET_NO_WITHDRAW = 1;
        // role
        public const int ROLE_ALL = 0;
        public const int CUSTOMER_ROLE = 1;
        public const int AGENT_ROLE = 2;

        // config
        public const string FIRST_LOGIN_ADD_POINT = "FirstLogin";
        public const string PROFIT = "Profit";
        public const string TIME_DELAY = "TimeWaiting";
        public const string LIMIT_IMAGE = "LimitCatImage";
        public const string SHIFT_TIME = "Shift";
        public const string MIN_BALANCE_SEND_REQUEST = "MinBalanceSendRequest";
        public const string MIN_BALANCE_SEND_REQUEST_FIRST = "MinBalanceSendRequestFirst";
        public const string MIN_BALANCE_SEND_MESSAGE = "MinBalanceSendMessage";
        public const string MAX_DISTANCE_SEND_REQUEST = "MaxDistanceSendRequest";
        public const string DAY_WITHDRAW = "DayWithdraw";
        public const string MIN_POINT_WITHDRAW = "MinPointWithdraw";
        public const string MIN_BALANCE_WITHDRAW = "MinBalanceWithdraw";
        public const string TIME_DELAY_PUSH_NOTI = "TimeDelayOrder";
        public const string TIME_START_ORDER = "TimeStartOrder";
        public const string LIMIT_CANCEL = "LimitCancel";
        public const string ConfirmationTime = "ConfirmationTime";
        public const string GPSNotValid = "GPSNotValid";
        public const string MaxArea = "MaxArea";
        public const string PENDING_TIME = "PendingTime";
        // transaction

        // rút tiền
        public const int TYPE_TRANSACTION_WITHDRAW = 1;
        // chuyển tiền
        public const int TYPE_TRANSACTION_TRANSFER_WALLET = 11;
        public const int TYPE_TRANSACTION_TRANSFER_NO_WALLET = 12;
        // nạp tiền
        public const int TYPE_TRANSACTION_RECHARGE = 2;
        // vnapy
        public const int TYPE_TRANSACTION_VNPAY = 3;
        // cộng điểm khi hoàn thành đơn
        public const int TYPE_TRANSACTION_ADD_POINT_WHEN_COMPELETE_CUSTOMER = 4;
        // cộng điểm từ hệ thống
        public const int TYPE_TRANSACTION_ADD_POINT_BY_ADMIN = 5;
        // hoàn trả điểm
        public const int TYPE_TRANSACTION_REFUND_POINT_BY_ADMIN = 6;
        public const int TYPE_TRANSACTION_REFUND_TRANSACTION = 13;
        public const int TYPE_TRANSACTION_SUBTRACT_WASHER_SUBMIT_ORDER = 7;
        public const int TYPE_TRANSACTION_REWARD_WASHER_COMPLETE_ORDER = 8;
        public const int TYPE_TRANSACTION_USE_POINT_CUSTOMER = 9;
        public const int TYPE_TRANSACTION_FIRST_LOGIN = 10;

        public static int[] LIST_STATUS_ADD = { 2, 4, 5, 6, 8, 10, 12, 13 };
        public const int TRANSACTION_PENDING = 1;
        public const int TRANSACTION_ADD_POINT = 1;
        public const int TRANSACTION_SUBTRACT_POINT = 2;


        public const string TYPE_TRANSACTION_WITHDRAW_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_RECHARGE_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_SUBTRACT_POINT_BUY_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_ADD_POINT_BUY_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_ADD_POINT_BY_ADMIN_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_REFUND_POINT_BY_ADMIN_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_SUBTRACT_WASHER_SUBMIT_ORDER_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_REWARD_WASHER_COMPLETE_ORDER_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_USE_POINT_CUSTOMER_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";
        public const string TYPE_TRANSACTION_FIRST_LOGIN_ICON = "https://cdn4.iconfinder.com/data/icons/finance-and-banking-free/64/Finance_loan_money-512.png";

        public const int STATUS_TRANSACTION_SUCCESS = 1;
        public const int STATUS_TRANSACTION_WAITING = 2;
        public const int STATUS_TRANSACTION_FLASE = 0;
        public const int STATUS_TRANSACTION_APPROVE = 3;

        /// <summary>
        /// request for Admin
        /// </summary>
        public const int STATUS_REQUEST_SUCCESS = 1;
        public const int STATUS_REQUEST_REJECT = 0;
        public const int STATUS_REQUEST_PENDING = 2;
        public const int STATUS_REQUEST_APPROVE = 3;


        // transaction type
        public const int RECHAGE = 1;
        public const int SUBTRACT_POINT = 2;

        public const int TRANSACTION_TYPE_RECHARGE_WALLET_WITHDRAW = 1;
        public const int TRANSACTION_TYPE_RECHARGE_WALLET_NO_WITHDRAW = 2;
        // orderService
        public const int ORDER_STATUS_WAITING = 1;
        public const int ORDER_STATUS_CONFIRM = 2;
        public const int ORDER_STATUS_COMPLETE = 3;
        public const int ORDER_STATUS_WASHING = 5;
        public const int ORDER_STATUS_CONFIRM_WASHING = 6;
        public const int ORDER_STATUS_CANCEL = 0;
        public const int ORDER_STATUS_NO_CONFIRM = 4;
        public const int ORDER_STATUS_FIND_ORTHER_WASHER = 9;
        public const int ORDER_STATUS_CANT_SEE = -1;


        public const int TYPE_MAIN_SERVICE = 1;
        public const int TYPE_ADDITION_SERVICE = 2;

        public const int TYPE_ORDER_SERVICE_IMAGE_CAR = 1;
        public const int TYPE_ORDER_SERVICE_IMAGE_PARK = 2;
        // orther
        public const int TIME_EXPRICE_TOKEN = 3;
        public const int PER_PAGE = 16;
        public const string HTTP = "http://";
        // DeleteImageType
        public const int DELETE_IMAGE_CAR = 1;
        public const int DELETE_IMAGE_ORDER_STEP = 2;

        // coupon
        public const int COUPON_PRODUCT = 1;
        public const int COUPON_ITEM = 2;

        public const int COUPON_TYPE_PERCENT = 1;
        public const int COUPON_TYPE_DISCOUNT = 2;


        public const int COUPON_NOT_USED = 1;
        public const int COUPON_USED = 2;

        //
        public const string URL_CAR_BRAND = "https://private-anon-32ae3f7662-carsapi1.apiary-mock.com/manufacturers";
        public const string URL_CAR_MODEL = "https://private-anon-32ae3f7662-carsapi1.apiary-mock.com/cars";
        // KeyGoogle
        public const string KEY_GOOGLE_MAP = "AIzaSyDMw3EgsWHTOExuSV2xzt2xGSKGHR9VZMQ";
        public const string KEY_PROVINCE = "administrative_area_level_1";
        public const string KEY_DISTRICT = "administrative_area_level_2";
        public const string STATUS_SUCCESS = "OK";
        // Washer
        public const string KEY_CODE_WASHER = "CM";
        public const int MAX_LENGT_ID = 2;

        // typeNoti
        public const int NOTI_ORDER_STATUS_WAITING = 1;
        public const int NOTI_ORDER_STATUS_CONFIRM = 2;
        public const int NOTI_ORDER_STATUS_COMPLETE = 3;
        public const int NOTI_ORDER_STATUS_WASHING = 4;
        public const int NOTI_ORDER_STATUS_CANCEL = 0;
        public const int NOTI_WALLET_NEED_RECHARGE = 5;
        public const int NOTI_HAVE_NEWS = 6;
        public const int NOTI_TRANSACTION_WALLET = 7;
        public const int NOTI_TRANSACTION_SUCCESS = 8;
        public const int NOTI_UPLOAD_IMAGE = 9;
        public const int NOTI_FROM_ADMIN = 10;
        public const int NOTI_REVIEW = 11;
        public const int NOTI_TRANSACTION_FLASE = 12;


        // Payment
        public const int PAYMENT_TYPE_NO_VNP = 1;
        public const int PAYMENT_TYPE_VNP = 2;

        public const int STATUS_PAYMENT_WAITING = 0;
        public const int STATUS_PAYMENT_COMPLETE = 1;
        public const int STATUS_PAYMENT_CANCEL = 2;

        // new
        public const int NEWS_PUSH_NOTI = 1;
        public const int NEWS_NO_PUSH_NOTI = 0;
    }

    public class MessVN
    {
        // Return output ChangeStatus
        public const string CHANGE_STATUS_SUCCES = "Chuyển trạng thái thành công";
        public const string CHANGE_STATUS_PERMISSION_DINE = "Không có quyền đổi trạng thái đơn hàng";
        public const string CHANGE_STATUS_CONFIRM_ERROR = "Đơn hàng đã có người khác nhận";
        public const string CHANGE_STATUS_HAVE_ORDER = "Vui lòng hoàn thành đơn để bắt đầu đơn mới";
        public const string CHANGE_STATUS_FINISH_ERROR = "Vui lòng tải đủ ảnh trước khi hoàn thành đơn";
        public const string CHANGE_STATUS_CHANGED = "Đơn hàng đã chuyển trạng thái";
        public const string CHANGE_STATUS_CANCEL = "Đơn hàng đã bị hủy";
        public const string CHANGE_STATUS_FALSE = "Bạn chưa thể thực hiện thao tác này";
        public const string CHANGE_STATUS_IMAGE_FLASE = "Vui lòng tải đủ ảnh trước khi thực hiện tác vụ này";
        public const string CHANGE_STATUS_NOT_ENOUGH_AMOUNT = "Tài khoản của bạn không đủ để nhận đơn này";
        /// <summary>
        /// Mess type Transacsion
        /// </summary>
        /// 

        public const string TYPE_TRANSACTION_WITHDRAW_STR = " từ yêu cầu rút điểm ";
        public const string TYPE_TRANSACTION_RECHARGE_STR = " điểm từ việc nạp tiền";
        public const string TYPE_TRANSACTION_SUBTRACT_POINT_BUY_PRODUCT_STR = " điểm từ việc rút tiền";
        public const string TYPE_TRANSACTION_ADD_POINT_WHEN_COMPELETE_CUSTOMER_STR = " điểm thưởng sau khi hoàn tất đơn hàng ";
        public const string TYPE_TRANSACTION_ADD_POINT_BY_ADMIN_STR = " điểm từ hệ thống";
        public const string TYPE_TRANSACTION_REFUND_POINT_BY_ADMIN_STR = " điểm từ hệ thống do huỷ đơn hàng ";
        public const string TYPE_TRANSACTION_SUBTRACT_WASHER_SUBMIT_ORDER_STR = " điểm khi nhận đơn hàng ";
        public const string TYPE_TRANSACTION_REWARD_WASHER_COMPLETE_ORDER_STR = " điểm thưởng khi hoàn thành đơn hàng ";
        public const string TYPE_TRANSACTION_USE_POINT_CUSTOMER_STR = " điểm cho đơn hàng ";
        public const string TYPE_TRANSACTION_FIRST_LOGIN_STR = " điểm cho lần đầu đăng nhập";
        public const string MESS_ADD = "Nhận ";
        public const string MESS_SUBTRACT = "Trừ ";
        /// <summary>
        ///  mess Result
        /// </summary>
        public const string REQUIRE_FIELD = "Vui lòng không để trống!";
        public const string INVALID_NUMBER = "Chỉ được phép nhập số!";
        public const string CONFIRM_FAIL = "Hệ thống đã hết thẻ vui lòng chọn sản phẩm khác";
        public const string SUCCESS_STR = "Thành công";
        public const string ERROR_STR = "Hệ thống bảo trì";
        public const string TOKEN_ERROR = "Tài khoản của bạn đã được đăng nhập ở nơi khác";
        public const string NOT_FOUND_MESS = "Không tồn tại";
        public const string PERMISSION_DENIED_MES = "Không có quyền truy cập";
        /// <summary>
        /// orther
        /// </summary>
        public const string LIMIT_IMAGE_ERROR = "Vượt quá số ảnh quy định";
        public const string FALSE_CONVERT_DATETIME = "Sai định dạng ngày";
        public const string PAGE_ERROR = "Trang không tồn tại";
        public const string LICENSEPLATES_ERROR = "Biển số xe đã tồn tại";
        /// <summary>
        /// TranSaction
        /// </summary>
        public const string Transaction_Succes = "Giao dịch Thành công";
        public const string Transaction_False = "Giao dịch thất bại mã lỗi : ";
        public const string Transaction_False_view = "Giao dịch thất bại";

        public const string NOTI_HEADER = "Thông báo";
        /// <summary>
        /// Order
        /// </summary>
        public const string WASHER = "Chuyên gia ";
        public const string LIMIT_CANCEL = "Bạn đã huỷ quá nhiều lần , vui lòng thanh toán bằng VNPAY";
        public const string LIST_ITEM_NULL = "Vui lòng chọn gói dịch vụ";
        public const string WALLET_ERROR = "Ví của bạn không có điểm";
        public const string ITEM_MAIN_ERROR = "Chỉ được chọn một gói dịch vụ chính";
        public const string CAR_ERROR = "Vui lòng chọn xe";
        public const string LOCATION_ERROR = "Vui lòng thử lại";
        public const string AREA_ERROR = "Khu vực chưa được hỗ trợ";
        public const string NO_WASHER = "Rất tiếc tất cả các chuyên gia đều bận vui lòng thử lại sau";
        public const string WASHER_NO_WORKING = " không thể thực hiện yêu cầu của bạn lúc này";
        public const string PLACE_ERROR = "Vui lòng thử lại";
        public const string HAVE_SHCEDULE = "Đã có lịch rửa xe trong thời gian này";
        public const string BOOK_DATE_ERROR = "Thời gian đặt lịch không hợp lệ";
        public const string COUPON_ERROR = "Mã giảm giá không tồn tại";
        public const string AGENT_ERROR = "Mã chuyên gia rửa xe không đúng";
        public const string REVIEW_ERROR = "Bạn chưa thể đánh chuyên gia rửa xe";
        public const string SHIFT_ERROR = "Hiện tại hệ thống không làm việc ở khung giờ này vui lòng chọn khung giờ khác";
        public const string PERMISSION_DENIED_CHANGE = "Bạn không có quyển thao tác với đơn này";
        public const string REASON_ERROR = "Vui lòng điền lý do bạn huỷ đơn hàng này";
        public const string LIMIT_CANCEL_ERROR = "Bạn đã huỷ quá nhiều lần , vui lòng thanh toán bằng VNPAY";
        public const string MAIN_SERVICE_NOT_FOUND = "Gói dịch vụ đang tạm dừng hoạt động";
        public const string ADDITION_SERVICE_ERROR = "Gói dịch vụ phụ đang tạm dừng hoạt động";


        /// <summary>
        /// Wallet
        /// </summary>
        public const string WALLET_NOT_FOUND = "Không tìm thấy ví ";
        public const string WALLET_DAY_WITHDRAW_FALSE_BEFORE = "Bạn không thể rút điểm trước ngày ";
        public const string WALLET_POINT_WITHDRAW_FALSE = "Số điểm của bạn không đủ để thực hiện giao dịch này";
        public const string WALLET_MIN_POINT_WITHDRAW_FALSE = "Số điểm rút của bạn ít nhất là ";
        public const string WALLET_MIN_BALANCE_WITHDRAW_FALSE_BEFORE = "Bạn phải có ít nhất ";
        public const string WALLET_MIN_BALANCE_WITHDRAW_FALSE_AFTER = " điểm trong ví để thực hiện giao dịch này";

        /// <summary>
        /// content NOTI
        /// </summary>
        public const string NOTI_ORDER_STATUS_WAITING = "Bạn có đơn hàng mới cần xác nhận";
        public const string NOTI_ORDER_STATUS_CONFIRM = "Đơn hàng bạn đặt đã được xác nhận";
        public const string NOTI_ORDER_STATUS_COMPLETE = "Xe của bạn đã được rửa xong ";
        public const string NOTI_ORDER_STATUS_WASHING = "Xe của bạn đang được Chuyên gia rửa";
        public const string NOTI_ORDER_STATUS_CANCEL = "Đơn hàng của bạn đã bị hủy";
        public const string NOTI_ORDER_STATUS_NO_CONFIRM = "Đơn hàng chưa có người xác nhận";
        public const string NOTI_WALLET_NEED_RECHARGE_BEFORE = "Ví điểm của bạn dưới ";
        public const string NOTI_WALLET_NEED_RECHARGE_AFTER = " vui lòng nạp thêm điểm để tiếp tục sử dụng dịch vụ";
        public const string NOTI_WALLET_NEED_RECHARGE_AFTER2 = " vui lòng nạp thêm điểm để nhận đơn mới";
        public const string NOTI_TRANSACTION_AMOUNT = "Số điểm: ";
        public const string NOTI_TRANSACTION_BALANCE = "/nSố dư: ";
        public const string NOTI_TRANSACTION_SUCCESS = "Giao dịch hoàn thành";
        public const string NOTI_UPLOAD_IMAGE = "Thợ rửa xe vừa tải lên ảnh ";
        public const string NOTI_FROM_ADMIN = "Thông báo từ hệ thống";
        public const string NOTI_REVIEW = "Bạn vừa được đánh giá ";

        /// <summary>
        /// Login
        /// </summary>
        public const string LOGIN_ERROR = "Sai tài khoản hoặc mật khẩu";
        public const string PASS_ERROR = "Mật khẩu không đúng";
        public const string PHONE_ERROR = "Số điện thoại chưa được đăng ký";
        public const string EMAIL_ERROR = "Email không đúng";
        public const string EMAIL_USED = "Email đã được sử dụng";
        public const string PARAM_ERROR = "Vui lòng nhập đầy đủ thông tin";
        public const string OTP_ERROR = "Vui lòng nhập lại mã OTP";
        public const string OTP_SUCCES = "Xác nhận tài khoản thành công";
        public const string ACCOUNT_EXISTS = "Tài khoản đã tồn tại";

        public const string MAX_CAR_IMAGE_ERROR = "Bạn chỉ có thể tải lên tối đa ";
        public const string ADD_CAR_SUCCESS = "Chúng tôi đã gửi yêu cầu của bạn lên hệ thống vui long đợi phản hồi của quản lý";
    }

    public class MessEN
    {
        // Return output ChangeStatus
        public const string CHANGE_STATUS_SUCCES = "Order's status is completed";
        public const string CHANGE_STATUS_PERMISSION_DINE = "Permission dinied";
        public const string CHANGE_STATUS_CONFIRM_ERROR = "This application already has recipients, you cannot accept it";
        public const string CHANGE_STATUS_HAVE_ORDER = "You have an incomplete application. Please complete the application to start a new application";
        public const string CHANGE_STATUS_FINISH_ERROR = "Please upload enough photos before completing the application";
        public const string CHANGE_STATUS_CHANGED = "The Status of order had changed";
        public const string CHANGE_STATUS_FALSE = "You cannot do this yet";
        public const string CHANGE_STATUS_IMAGE_FLASE = "Please upload all images before taking this action";
        public const string CHANGE_STATUS_NOT_ENOUGH_AMOUNT = "Your Account Balance is not sufficient to receive this application";
        public const string CHANGE_STATUS_CANCEL = "The order has been canceled";
        /// <summary>
        /// Mess type Transacsion
        /// </summary>
        public const string TYPE_TRANSACTION_WITHDRAW_STR = "Withdraw";
        public const string TYPE_TRANSACTION_RECHARGE_STR = "Top up";
        public const string TYPE_TRANSACTION_SUBTRACT_POINT_BUY_PRODUCT_STR = " points when buying products ";
        public const string TYPE_TRANSACTION_ADD_POINT_WHEN_COMPELETE_CUSTOMER_STR = " reward point after completing the service ";
        public const string TYPE_TRANSACTION_ADD_POINT_BY_ADMIN_STR = " points from the system ";
        public const string TYPE_TRANSACTION_REFUND_POINT_BY_ADMIN_STR = " points from the system";
        public const string TYPE_TRANSACTION_SUBTRACT_WASHER_SUBMIT_ORDER_STR = " points when confirming applications ";
        public const string TYPE_TRANSACTION_REWARD_WASHER_COMPLETE_ORDER_STR = " points for completing orders ";
        public const string TYPE_TRANSACTION_USE_POINT_CUSTOMER_STR = " points for order ";
        public const string TYPE_TRANSACTION_FIRST_LOGIN_STR = " points for the first login";
        public const string MESS_BONUS = "You have been added ";
        public const string MESS_SUBTRACT = "You are subtracted ";
        /// <summary>
        ///  mess Result
        /// </summary>
        //public const string REQUIRE_FIELD = "Vui lòng không để trống!";
        public const string INVALID_NUMBER = "You may only enter numbers";
        public const string SUCCESS_STR = "Success request";
        public const string ERROR_STR = "The system is maintenance";
        public const string TOKEN_ERROR = "Your account has been signed in elsewhere";
        public const string NOT_FOUND_MESS = "Data not found";
        public const string PERMISSION_DENIED_MES = "Permission deined";
        /// <summary>
        /// orther
        /// </summary>
        public const string LIMIT_IMAGE_ERROR = "The number of images has exceeded the number of images specified";
        public const string FALSE_CONVERT_DATETIME = "Wrong date format";
        public const string PAGE_ERROR = "Wrong param page";
        public const string LICENSEPLATES_ERROR = "License plate already exists";

        /// <summary>
        /// TranSaction
        /// </summary>
        public const string Transaction_Succes = "Transaction completed";
        public const string Transaction_False = "Transaction failed code: ";
        public const string Transaction_False_view = "Giao dịch thất bại";

        public const string NOTI_HEADER = "Notification";

        /// <summary>
        /// Order
        /// </summary>
        public const string WASHER = "Mater ";
        public const string LIMIT_CANCEL = "You have canceled too many times, please pay with VNPAY";
        public const string LIST_ITEM_NULL = "Please select one main service";
        public const string WALLET_ERROR = "Wallet balance is not enough";
        public const string ITEM_MAIN_ERROR = "Only one main service can be selected";
        public const string CAR_ERROR = "Please select your car before selecting service";
        public const string LOCATION_ERROR = "Please try again";
        public const string PLACE_ERROR = "Please try again";
        public const string AREA_ERROR = "Area is inactive";
        public const string NO_WASHER = "Sorry all the Mater are busy please try again later";
        public const string WASHER_NO_WORKING = " your request could not be processed at this time";
        public const string HAVE_SHCEDULE = "You had schedule";
        public const string BOOK_DATE_ERROR = "The booking time is not valid";
        public const string COUPON_ERROR = "The coupon failed";
        public const string AGENT_ERROR = "Wrong agent's code";
        public const string REVIEW_ERROR = "You cannot rate Washer yet";
        public const string SHIFT_ERROR = "Currently the system does not work at this time please select another time";
        public const string PERMISSION_DENIED_CHANGE = "You do not have an operation manual for this application";
        public const string REASON_ERROR = "Please enter your reason for canceling this service";
        public const string LIMIT_CANCEL_ERROR = "You have canceled too many times, please pay with VNPAY";
        public const string MAIN_SERVICE_NOT_FOUND = "The service is not working";
        public const string ADDITION_SERVICE_ERROR = "Have a addition service is not working";
        /// <summary>
        /// Wallet
        /// </summary>
        public const string WALLET_NOT_FOUND = "Wallet is not found";
        public const string WALLET_DAY_WITHDRAW_FALSE_BEFORE = "You cant withdraw before ";
        public const string WALLET_POINT_WITHDRAW_FALSE = "wallet balance is not enough";
        public const string WALLET_MIN_POINT_WITHDRAW_FALSE = "Your withdrawal amount is at least ";
        public const string WALLET_MIN_BALANCE_WITHDRAW_FALSE_BEFORE = "You must have at least ";
        public const string WALLET_MIN_BALANCE_WITHDRAW_FALSE_AFTER = " points in you'r wallet to make this transaction";

        /// <summary>
        /// content NOTI
        /// </summary>
        public const string NOTI_ORDER_STATUS_WAITING = "You have new orders to confirm";
        public const string NOTI_ORDER_STATUS_CONFIRM = "Your order has been confirmed";
        public const string NOTI_ORDER_STATUS_COMPLETE = "Your car has finished washing ";
        public const string NOTI_ORDER_STATUS_WASHING = "Your car is being washed by car washers";
        public const string NOTI_ORDER_STATUS_CANCEL = "Your order has been cancel";
        public const string NOTI_ORDER_STATUS_NO_CONFIRM = "Order has not been confirmed";
        public const string NOTI_WALLET_NEED_RECHARGE_BEFORE = "Your wallet is under ";
        public const string NOTI_WALLET_NEED_RECHARGE_AFTER = " points, please top up to continue using the service";
        public const string NOTI_WALLET_NEED_RECHARGE_AFTER2 = "points, please submit additional points to receive a new application";
        public const string NOTI_TRANSACTION_AMOUNT = "Amount: ";
        public const string NOTI_TRANSACTION_BALANCE = "/n Balance: ";
        public const string NOTI_TRANSACTION_SUCCESS = "Transaction complete";
        public const string NOTI_UPLOAD_IMAGE = "The car washer has just uploaded the photo ";
        public const string NOTI_FROM_ADMIN = "Notification from the System";
        public const string NOTI_REVIEW = "You have just been evaluated ";
        /// <summary>
        /// Login
        /// </summary>
        public const string LOGIN_ERROR = "Wrong account or password";
        public const string EMAIL_ERROR = "Wrong email";
        public const string PASS_ERROR = "Wrong password";
        public const string EMAIL_USED = "Email already exists";
        public const string PARAM_ERROR = "Please enter full information";
        public const string OTP_ERROR = "Please enter the OTP code again";
        public const string OTP_SUCCES = "Account verification successful";
        public const string ACCOUNT_EXISTS = "Account already exists";
        public const string PHONE_ERROR = "The Phone number is not register";

        public const string MAX_CAR_IMAGE_ERROR = "You can only upload at most ";
        public const string ADD_CAR_SUCCESS = "We have submitted your request to the system, please wait for the management's response";

    }

    public class CustomerOnesignal
    {
        public const string APP_ID = "5a36e238-e0b9-481b-82a6-f496aa9b3682";
        public const string ANDROID_CHANNEL_ID = "c8a999be-9cbe-4a17-9839-a1c1c7acc553";
    }

    public class WasherOnesignal
    {
        public const string APP_ID = "ac4b681b-0885-400d-8fe4-ec83a8f67547";
        public const string ANDROID_CHANNEL_ID = "257fe7ea-90a6-4772-a16b-25d0c061f01c";
        public const string NO_SOUND = "ea8f7e6d-106f-47af-a537-c3d5837a5435";
    }

    public class OTPTEST
    {
        public const string SEND_TIME = "null";
        public const string USER = "vmgtest1";
        public const string PASS = "vmG@123b";
        public const string ALIAS = "VMGtest";
        public const string LINK_MESS = "http://brandsms.vn:8018/VMGAPI.asmx/BulkSendSms?";
        public const string CONTENT_MESS = "Ma xac nhan cua quy khach la ";
    }
    public class OTPRelease
    {
        public const string ALIAS = "Carrect.vn";
        public const string LINK_MESS = "http://api.brandsms.vn/api/SMSBrandname/SendSMS";
        public const string CONTENT_MESS = " la ma xac nhan cua quy khach";
        public const string TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c24iOiJldmVyZ2xvd3ciLCJzaWQiOiI1MTRhODNkNS00M2Y1LTQ2YWMtOWQxYi03YTYwZmQwYzg2OTMiLCJvYnQiOiIiLCJvYmoiOiIiLCJuYmYiOjE1OTA0NjA0NDMsImV4cCI6MTU5MDQ2NDA0MywiaWF0IjoxNTkwNDYwNDQzfQ.DhRjrL1x0HlhtaUnlDWkZyNTZYXXopnbe1dgB35d2Ms";
    }
}
