//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoApp.Services
{
    using Entity;
    using IServices;
    using IRepository;
    
    public partial class pli_loginAccountService:BaseServices<pli_loginAccount>, Ipli_loginAccountService
    {
    	private Ipli_loginAccountRepository _wgpli_loginAccountRepository;
    	public pli_loginAccountService(Ipli_loginAccountRepository wgpli_loginAccountRepository)
            {
                this._wgpli_loginAccountRepository = wgpli_loginAccountRepository;
                base.BaseRepository = wgpli_loginAccountRepository;
            }
     }
}
