<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>Air Fuel Ratio</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Air Fuel Ratio</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Afr Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>AirFuelRatio.Main</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>
								Luft-Kraftstoff-Verhältnis
							</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN"></L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Im Modul Luft-Kraftstoff-Verhältnis (AirFuelRatio) wird auf
									Basis eines vorgegebenen
									Lambdawertes das benötigte Verhältnis
									von Luft zu Kraftstoff berechnet. Dazu wird
									über das Kennfeld
									<TT TYPE="PRM">Afr_rpmEngSpdfacRelAir2facLambdaReqBase_MAP</TT>
									aus der Drehzahl
									<TT TYPE="VARIABLE">Epm_rpmEngSpd</TT>
									und der relativen Füllung Amf_facRelAir ein Basiswert für
									Lambda
									ermittelt und anschließend mit Korrekturen beaufschlagt.
									Die Grundparametrierung aus
									Erfahrung heraus liegt hier über
									alle Drehzahlbereiche im Teillastbereich, d. h. bei relativen
									Füllungen unter 80%, bei &#x3bb;= 1.0 und im Volllastbereich
									über 120% bei &#x3bb;= 0.7. Im
									Übergangsbereich dazwischen
									findet eine lineare Interpolation statt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Korrigiert wird zum einen abhängig von der Kühlmitteltemperatur
									Ctc_atCool, die über
									die Kennlinie
									<TT TYPE="PRM">Afr_atCool2facLambdaReqCorr_CUR</TT>
									eingerechnet wird. Bei kaltem Motor
									findet eine Gemischanfettung
									zur Erwärmung des Motors statt, die ab rund 50&#176;C zu
									Null
									wird. Zum anderen kann eine Frischlufttemperaturabhängige
									(Mtc_atMani über
									<TT TYPE="PRM">Afr_atMani2facLambdaReqCorr_CUR</TT>
									) Anfettung oder Abmagerung durchführt werden.
									Dieses Kennfeld
									ist von Grund auf mit Null bedatet. Der so errechnete
									Lambdawert kann
									durch setzen des Flags
									<TT TYPE="PRM">Afr_flgLambdaReqOverride</TT>
									manuell mit
									<TT TYPE="PRM">Afr_facLambdaReqMan</TT>
									überschrieben werden, bevor er als Nachricht exportiert wird.
									Gleichung 5.7 zeigt die
									Berechnungen zum Lambdawert.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Weiterhin wird aus dem Lambdawert durch Multiplikation mit dem
									stöchiometrischen Faktor
									<TT TYPE="PRM">Afr_facStoich</TT>
									das Luft-Kraftstoff-Verhältnis
									<TT TYPE="VARIABLE">Afr_facRatio</TT>
									errechnet Gleichung 5.8.
									Auch hier besteht die Möglichkeit, den
									errechneten Wert manuell mit
									<TT TYPE="PRM">Afr_facRatioMan</TT>
									zu
									überschreiben (setzen des Flags
									<TT TYPE="PRM">Afr_flgRatioOverride</TT>
									), bevor er als Nachricht exportiert
									wird. Die Auswertung der
									Funktion Afr_calc erfolgt im Synchron-Raster.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>afr_jpg_1</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>afr_jpg_2</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
