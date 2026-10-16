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
									<SHORT-NAME>Lcc.Lcc_mdl</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="SVG" SCALE="0.61">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>
								Lambdakorrektur
							</SHORT-NAME>
							<P>
								<L-1 L="DE">
									In die Motorsteuerung werden 2 Arten von
									Lambdaregelungen
									integriert.
									Zum Einen ein Zweipunktregler und
									zum Anderen ein stetiger
									Regler, als PID-Regler ausgeführt. Es
									werden zwei Regelkonzepte
									getestet, um
									das bestmögliche Ergebnis
									zu erzielen. Ein PID-Regler ist zudem
									schwer zu
									parametrieren, da
									die Regelstrecke eine Totzeit beinhaltet. Die verwendete
									Lambdasonde ist eine Breitbandsonde, die auch eine fette und
									magere Gemisch-
									Zusammensetzung erkennt. So ist es auch mit dem
									Zweipunktregler möglich fett
									und mager zu fahren.
								</L-1>
							</P>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Lambdasondenerfassung</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Dieses Modul dient ausschließlich zur Inbetriebnahme
									der Lambdaregelung. Zur
									Erfassung dient ein Analogeingang, bis
									die eigentliche Lambdaerfassung durch
									die Basissoftware
									unterstützt wird. Dieses analoge Spannungssignal wird im
									Kennfeld zu einem
									Lambdawert umgerechnet und in die Variable
									Lamsoni geschrieben.
								</L-1>
							</P>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Bedingungen für aktive Lambdaregelung</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Die Lambdaregelung
									ist im Normalbetrieb aktiv.
									Ausnahmen sind der Schubbetrieb
									(Isc_flgFuelCutoff),
									bei dem
									keine Einspritzung stattfindet und während des
									Startvorgangs
									(Stc_flgFuelCorrActive).
									Bei diesem wird erstens die
									Einspritzmenge gesteuert und zweitens
									muss die
									Lambdasonde
									vorgeheizt werden, damit sie betriebsbereit ist. Die
									Umschaltung
									zwischen PID-Regelung und Zweipunktregelung erfolgt
									über den Parameter
									Lcc_flgSwitch2PIDController.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Lcc.Lcc_mdl.Two-point-controller</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE"> Two-point-controller </L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Zweipunktregler</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Der
									Zweipunktregler funktioniert über einen
									Integrator. Wird zum Beispiel Lambda
									1 geregelt und die
									Lambdasonde gibt einen mageren Wert aus
									(Lambda > 1) wird
									der
									Korrekturfaktor solange erhöht, bis die Einspritzung so groß
									ist, dass
									ein fetter Lambdawert vorliegt (Lambda kleiner 1).
									Danach wird der
									Korrekturfaktor
									nach unten korrigiert bis der
									Lambdawert wieder mager ist. Im
									Programm ist
									dies folgendermaßen
									angelegt: Der Lambdawert wird mit dem
									Lambda-Sollwert
									verglichen. Ist der Lambdawert größer, wird eine logische 0
									ausgegeben,
									andersrum
									eine logische 1. Sobald der Zustand
									wechselt, wird der verwendete
									Integrator
									initialisiert und es
									wird ein Startwert gesetzt. Dieser Startwert entspricht
									der
									Summe aus Integratorausgang und einem Korrekturfaktor
									(Lcc_facInitValue).
									Der Korrekturfaktor erhöht die Dynamik der
									Regelung. Der
									Integratoreingang
									wird aus dem Kennfeld
									Lcc_EngSpd2facIntegrator_CUR gebildet und ist
									abhängig
									von der
									Drehzahl. Der Ausgang des Integrators ist begrenzt durch
									Lcc_LambdaCorrMinTPC
									und Lcc_LambdaCorrMaxTPC.
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Lcc.Lcc_mdl.PID-Controller</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE"> PID-Controller </L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>PID-Regler</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Der Eingang
									des PID-Reglers wird aus der Differenz zwischen
									Lambdawert und
									Lambda-Sollwert
									gebildet. P-, I- und D-Anteil1 sind
									abhängig von der Drehzahl und des
									Saugrohrdrucks.
									Die
									Verstärkungsfaktoren sind in Lcc_facKLambdaCorrPID_MAP
									(P-Anteil),
									Lcc_tiTnLambdaCorrPID_MAP
									(IAnteil) und Lcc_tiTvLambdaCorrPID_MAP
									(D-Anteil) hinterlegt. Auch der
									PIDRegler
									begrenzt durch
									T2t_ThrValveReqCorrMin und T2t_ThrValveReqCorrMax den
									Korrekturfaktor.
								</L-1>
							</P>

							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Lcc.Lcc_mdl.PID-Controller.PID_Limit_AWU</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
											PID-Controller
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71" />
								</L-GRAPHIC>
							</FIGURE>

							<P>
								<L-1 L="DE">
									Die Auswertung der Funktion Lcc_calc erfolgt im
									Synchron-Raster.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
