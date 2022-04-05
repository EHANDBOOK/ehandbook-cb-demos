<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE 
MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN"
"fsx_v1_1_0.ml.dtd">
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
						<SHORT-NAME>Lambda Correction Calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Lambda Correction Calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Lcc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>							
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>LambdaControl.Main</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Lambdakorrektur</SHORT-NAME>
							<P>
								<L-1 L="DE">In die Motorsteuerung werden 2 Arten
									von Lambdaregelungen integriert. Zum Einen ein
									Zweipunktregler und zum Anderen ein stetiger
									Regler, als PID-Regler ausgef&#252;hrt. Es werden
									zwei Regelkonzepte getestet, um das
									bestm&#246;gliche Ergebnis zu erzielen. Ein
									PID-Regler ist zudem schwer zu parametrieren, da
									die Regelstrecke eine Totzeit beinhaltet. Die
									verwendete Lambdasonde ist eine Breitbandsonde, die
									auch eine fette und magere Gemisch- Zusammensetzung
									erkennt. So ist es auch mit dem Zweipunktregler
									m&#246;glich fett und mager zu fahren.</L-1>
							</P>
							<P>
								<L-1 L="DE">Lambdasondenerfassung:</L-1>
							</P>
							<P>
								<L-1 L="DE">Dieses Modul dient ausschlie&#223;lich
									zur Inbetriebnahme der Lambdaregelung. Zur
									Erfassung dient ein Analogeingang, bis die
									eigentliche Lambdaerfassung durch die Basissoftware
									unterst&#252;tzt wird. Dieses analoge
									Spannungssignal wird im Kennfeld zu einem
									Lambdawert umgerechnet und in die Variable Lamsoni
									geschrieben.</L-1>
							</P>
							<P>
								<L-1 L="DE">Bedingungen f&#252;r aktive
									Lambdaregelung:</L-1>
							</P>
							<P>
								<L-1 L="DE">Die Lambdaregelung ist im Normalbetrieb
									aktiv. Ausnahmen sind der Schubbetrieb
									(Isc_flgFuelCutoff), bei dem keine Einspritzung
									stattfindet und w&#228;hrend des Startvorgangs
									(Stc_flgFuelCorrActive). Bei diesem wird erstens
									die Einspritzmenge gesteuert und zweitens muss die
									Lambdasonde vorgeheizt werden, damit sie
									betriebsbereit ist. Die Umschaltung zwischen
									PID-Regelung und Zweipunktregelung erfolgt
									&#252;ber den Parameter
									Lcc_flgSwitch2PIDController.</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>
										LambdaControl.Main.Two-point-controller</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">Two-point-controller</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71"></GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">Zweipunktregler:</L-1>
							</P>
							<P>
								<L-1 L="DE">Der Zweipunktregler funktioniert
									&#252;ber einen Integrator. Wird zum Beispiel
									Lambda 1 geregelt und die Lambdasonde gibt einen
									mageren Wert aus (Lambda &gt; 1) wird der
									Korrekturfaktor solange erh&#246;ht, bis die
									Einspritzung so gro&#223; ist, dass ein fetter
									Lambdawert vorliegt (Lambda kleiner 1). Danach wird
									der Korrekturfaktor nach unten korrigiert bis der
									Lambdawert wieder mager ist. Im Programm ist dies
									folgenderma&#223;en angelegt: Der Lambdawert wird
									mit dem Lambda-Sollwert verglichen. Ist der
									Lambdawert gr&#246;&#223;er, wird eine logische 0
									ausgegeben, andersrum eine logische 1. Sobald der
									Zustand wechselt, wird der verwendete Integrator
									initialisiert und es wird ein Startwert gesetzt.
									Dieser Startwert entspricht der Summe aus
									Integratorausgang und einem Korrekturfaktor
									(Lcc_facInitValue). Der Korrekturfaktor erh&#246;ht
									die Dynamik der Regelung. Der Integratoreingang
									wird aus dem Kennfeld Lcc_EngSpd2facIntegrator_CUR
									gebildet und ist abh&#228;ngig von der Drehzahl.
									Der Ausgang des Integrators ist begrenzt durch
									Lcc_LambdaCorrMinTPC und
									Lcc_LambdaCorrMaxTPC.</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>
										LambdaControl.Main.PID-Controller</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">PID-Controller</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71"></GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">PID-Regler:</L-1>
							</P>
							<P>
								<L-1 L="DE">Der Eingang des PID-Reglers wird aus
									der Differenz zwischen Lambdawert und
									Lambda-Sollwert gebildet. P-, I- und D-Anteil1 sind
									abh&#228;ngig von der Drehzahl und des
									Saugrohrdrucks. Die Verst&#228;rkungsfaktoren sind
									in Lcc_facKLambdaCorrPID_MAP (P-Anteil),
									Lcc_tiTnLambdaCorrPID_MAP (IAnteil) und
									Lcc_tiTvLambdaCorrPID_MAP (D-Anteil) hinterlegt.
									Auch der PIDRegler begrenzt durch
									T2t_ThrValveReqCorrMin und T2t_ThrValveReqCorrMax
									den Korrekturfaktor.</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>PID_Limit_AWU.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">PID Limit</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71"></GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">Die Auswertung der Funktion Lcc_calc
									erfolgt im Synchron-Raster.</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
