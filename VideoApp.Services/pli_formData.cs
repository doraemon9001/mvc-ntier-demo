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
    
    public partial class pli_formDataService:BaseServices<pli_formData>, Ipli_formDataService
    {
    	private Ipli_formDataRepository _wgpli_formDataRepository;
    	public pli_formDataService(Ipli_formDataRepository wgpli_formDataRepository)
            {
                this._wgpli_formDataRepository = wgpli_formDataRepository;
                base.BaseRepository = wgpli_formDataRepository;
            }
     }
}
