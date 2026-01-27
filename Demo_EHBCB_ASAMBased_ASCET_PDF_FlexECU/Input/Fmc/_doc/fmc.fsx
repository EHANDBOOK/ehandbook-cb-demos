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
						<SHORT-NAME>Fuel Mass Calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Fuel Mass Calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Fmc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>FuelMass.Main</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>
								Einspritzmenge
							</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Im Modul Einspritzmenge (FuelMass) wird die zur Verbrennung
									benötigte Kraftstoffmasse
									<TT TYPE="VARIABLE">Fmc_mFuel</TT>
									berechnet. Dazu wird zunächst der Quotient aus der Luftmasse im
									Zylinder
									<TT TYPE="VARIABLE">Amf_mAirPerStr</TT>
									und dem Luft-Kraftstoff-Verhältnis
									<TT TYPE="VARIABLE">Afr_facRatio</TT>
									gebildet und mit dem
									Korrekturwert
									<TT TYPE="VARIABLE">Lcc_facLambdaCorr</TT>
									aus der Lambdaregelung multipliziert.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Da bei Saugrohreinspritzung im Gegensatz zur Direkteinspritzung
									zusätzlich verschiedene
									ungewünschte Effekte auftreten,
									wieWandfilm, Verzugszeit, usw., wird zur Verbesserung der
									Dynamik bei Lastwechseln eine zusätzliche Korrektur
									<TT TYPE="VARIABLE">Fmc_mFuelCorr</TT>
									der Einspritzmenge
									durchgeführt. Dazu wird ein Differenzierer
									mit anschließendem Abklingverhalten verwendet.
									Je größer die
									Änderung der Einspritzmenge ist, desto stärker reagiert das
									DT1-Glied.
									Dadurch wird beispielsweise erreicht, dass bei einer
									Erhöhung der Luftmasse, was eine Erhöhung der Kraftstoffmenge
									zur Folge hat, zusätzlich Kraftstoff eingespritzt wird, der
									die
									Wandfilmeffekte im Saugrohr ausgleicht. Über die folgenden
									Einspritzungen wird diese
									Menge reduziert, um wieder den
									gewünschten &#x3bb;-Wert zu erreichen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Auswertung der Funktion Fmc_calc erfolgt im
									Synchron-Raster, wodurch die Abtastzeit
									des DT1-Glieds
									drehzahlabhängig ist. Dabei erfolgt pro Zylinder eine
									Auswertung jede
									zweite Umdrehung, also insgesamt drei
									Auswertungen über 720°KW. Die Bildung des
									Maximums von Drehzahl
									und Eins dient einzig der Sicherheit. Es wird eine Division
									durch
									Null vermieden, wobei bei einer Drehzahl von Null nie ein
									Synchron-Interrupt ausgelöst wird
									und damit nie eine Auswertung
									der Funktion erfolgt. Gleichung 5.10 zeigt die Berechnung
									der
									Abtastzeit des DT1-Glieds.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Berechnung der einzuspritzenden Kraftstoffmasse ergibt sich
									damit, wie in Gleichung 5.9
									beschrieben. Durch das Flag
									<TT TYPE="PRM">Fmc_flgFuelMassOverride</TT>
									kann die Einspritzmenge manuell
									mit
									<TT TYPE="PRM">Fmc_mFuelMan</TT>
									überschrieben werden, bevor sie als Nachricht weitergereicht
									wird.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>fmc_jpg_1</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>fmc_jpg_2</SHORT-NAME>
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
