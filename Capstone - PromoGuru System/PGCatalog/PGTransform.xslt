<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <div class="Products">
      <xsl:apply-templates />
    </div>
  </xsl:template>
  
  <xsl:template match="Product">
    <div class="Product">
      <xsl:apply-templates />
    </div>
  </xsl:template>
  
  <xsl:template match="id">
    <div class="pid">
      Product Number: <xsl:value-of select ="."/>
    </div>
  </xsl:template>
  
  <xsl:template match="description">
    <div class="pdescription">
      Description: <xsl:value-of select="."/>
    </div>
  </xsl:template>
  
  <xsl:template match="imageLocation">
    <div class="pimagelocation">
      <img>
        <xsl:attribute name="src">
          <xsl:value-of select="."/>
        </xsl:attribute>
      </img>
    </div>
  </xsl:template>
  
  <xsl:template match="price">
    <div class="pprice">
      Price: $<xsl:value-of select="."/>
    </div>
  </xsl:template>
  
</xsl:stylesheet>