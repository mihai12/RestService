using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestServiceImpl" in both code and config file together.
    [ServiceContract]
    public interface IRestServiceImpl
    {

        //XML
        [OperationContract]
        [WebInvoke(
            Method          = "GET",
            ResponseFormat  = WebMessageFormat.Xml,
            BodyStyle       = WebMessageBodyStyle.Wrapped,
            UriTemplate     = "xml/{id}")]
        string XMLData(string id);

        //JSON
        [OperationContract]
        [WebInvoke(
            Method          = "GET",
            ResponseFormat  = WebMessageFormat.Json,
            BodyStyle       = WebMessageBodyStyle.Wrapped,
            UriTemplate     = "json/{id}")]
        string JSONData(string id);
    }
}
