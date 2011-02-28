/*
  Copyright 2007-2010 Stefano Chizzolini. http://www.pdfclown.org

  Contributors:
    * Stefano Chizzolini (original code developer, http://www.stefanochizzolini.it)

  This file should be part of the source code distribution of "PDF Clown library" (the
  Program): see the accompanying README files for more info.

  This Program is free software; you can redistribute it and/or modify it under the terms
  of the GNU Lesser General Public License as published by the Free Software Foundation;
  either version 3 of the License, or (at your option) any later version.

  This Program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
  either expressed or implied; without even the implied warranty of MERCHANTABILITY or
  FITNESS FOR A PARTICULAR PURPOSE. See the License for more details.

  You should have received a copy of the GNU Lesser General Public License along with this
  Program (see README files); if not, go to the GNU website (http://www.gnu.org/licenses/).

  Redistribution and use, with or without modification, are permitted provided that such
  redistributions retain the above copyright notice, license and disclaimer, along with
  this list of conditions.
*/

using org.pdfclown.documents;
using org.pdfclown.documents.interaction.navigation.document;
using org.pdfclown.files;
using org.pdfclown.objects;

using System;

namespace org.pdfclown.documents
{
  /**
    <summary>Named destinations [PDF:1.6:3.6.3].</summary>
  */
  [PDF(VersionEnum.PDF12)]
  public sealed class NamedDestinations
    : NameTree<Destination>
  {
    #region dynamic
    #region constructors
    public NamedDestinations(
      Document context
      ) : base(context)
    {}

    internal NamedDestinations(
      PdfDirectObject baseObject,
      PdfIndirectObject container
      ) : base(baseObject, container)
    {}
    #endregion

    #region interface
    #region public
    public override object Clone(
      Document context
      )
    {throw new NotImplementedException();}
    #endregion

    #region protected
    protected override Destination Wrap(
      PdfDirectObject baseObject,
      PdfIndirectObject container,
      PdfString name
      )
    {
      /*
        NOTE: A named destination may be either an array defining the destination,
        or a dictionary with a D entry whose value is such an array [PDF:1.6:8.2.1].
      */
      PdfDirectObject destinationObject;
      {
        PdfDataObject baseDataObject = File.Resolve(baseObject);
        if(baseDataObject is PdfDictionary)
        {destinationObject = ((PdfDictionary)baseDataObject)[PdfName.D];}
        else
        {destinationObject = baseObject;}
      }

      return Destination.Wrap(
        destinationObject,
        baseObject is PdfReference
          ? ((PdfReference)baseObject).IndirectObject
          : container,
        name
        );
    }
    #endregion
    #endregion
    #endregion
  }
}