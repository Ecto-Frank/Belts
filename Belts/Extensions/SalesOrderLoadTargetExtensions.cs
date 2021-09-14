using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class SalesOrderLoadTargetExtensions
    {
        public static string ToTargetSpecDisplay(this Data.Models.SalesOrderLoadTargetModel salesOrderTarget)
        {
            //if no reject, then 
            if (salesOrderTarget?.TargetReject.HasValue != true)//use != true because the result could be NULL or False
                return null;


            return $"{salesOrderTarget.TargetMin.Round(digits: 2).ToNumberDisplay(format: "0.00")} | {salesOrderTarget.TargetMax.Round(digits: 2).ToNumberDisplay(format: "0.00")} | {salesOrderTarget.TargetReject.Round(digits: 2).ToNumberDisplay(format: "0.00")}";
            /*<xsl:if test="not(contains(@Status,'loaded')) and number(@TargetReject) = @TargetReject">
                      <xsl:attribute name="style">background-color:#ffff99; white-space:nowrap; cursor:pointer</xsl:attribute>
                      <xsl:attribute name="onclick">
                        <xsl:value-of select="concat('javascript:handleOrder(',$apos,@TemplateOrder,$apos,')')" />
                      </xsl:attribute>
                      <xsl:if test="@TargetComments and not(@TargetComments = '')">
                        <xsl:attribute name="onmouseover">
                          <xsl:value-of select="concat('this.style.color=',$apos,'red',$apos,';','this._tip=',$apos,@TargetComments,$apos)" />
                        </xsl:attribute>
                      </xsl:if>
                      <xsl:value-of select="concat(format-number(@TargetMin,'##.00'),' | ',format-number(@TargetMax,'##.00'),' | ',format-number(@TargetReject,'##.00'))" />
                    </xsl:if>  */
        }
    }
}
