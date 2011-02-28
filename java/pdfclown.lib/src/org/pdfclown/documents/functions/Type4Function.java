/*
  Copyright 2010 Stefano Chizzolini. http://www.pdfclown.org

  Contributors:
    * Stefano Chizzolini (original code developer, http://www.stefanochizzolini.it)

  This file should be part of the source code distribution of "PDF Clown library"
  (the Program): see the accompanying README files for more info.

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

package org.pdfclown.documents.functions;

import org.pdfclown.PDF;
import org.pdfclown.VersionEnum;
import org.pdfclown.documents.Document;
import org.pdfclown.objects.PdfDirectObject;
import org.pdfclown.objects.PdfStream;
import org.pdfclown.util.NotImplementedException;

/**
	<b>PostScript calculator function</b> represented as a stream containing <i>code
	written in a small subset of the PostScript language</i> [PDF:1.6:3.9.4].
	
	@author Stefano Chizzolini (http://www.stefanochizzolini.it)
	@since 0.1.0
	@version 0.1.0
*/
@PDF(VersionEnum.PDF13)
public final class Type4Function
	extends Function<PdfStream>
{
  // <class>
	// <dynamic>
	// <constructors>
	//TODO:implement function creation!

	Type4Function(
		PdfDirectObject baseObject
		)
	{super(baseObject, null);} // NOTE: PdfStream is self-contained.
	// </constructors>

  // <interface>
  // <public>
	@Override
	public float[] calculate(
		float[] inputs
		)
	{
		// FIXME: Auto-generated method stub
		return null;
	}

	@Override
	public Object clone(
		Document context
		)
	{return new NotImplementedException();}
  // </public>
  // </interface>
	// </dynamic>
  // </class>
}
