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
						<SHORT-NAME>Idle Speed Control</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Idle Speed Control</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Isc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Isc.Isc_mdl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.61">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Module der Motorsteuerung</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Module der Motorsteuerung</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									In der Motorsteuerung sind die grundlegenden Module
									zum Betreiben eines
									Motors vorhanden. In diesem Kapitel werden
									neu implementierte Module
									beschrieben sowie Änderungen an
									bereits Vorhandenen. Zum Beispiel werden die
									zusätzlich
									benötigten Sensoren und Aktuatoren sowie weitere Module in die
									Motorsteuerung integriert. Das vorhandene Modell wird in
									Kapitel 2.8 genauer
									beschrieben.
								</L-1>
							</P>
							<CHAPTER>
								<SHORT-NAME>Regler Übersicht</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Regler Übersicht</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Die Motorsteuerung hat die Aufgabe bestimmte
										Betriebszustände zu regeln. Dafür
										sind mehrere Regler
										notwendig, die in reihe und parallel geschaltet sind.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>isc_png_1</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Reglerstruktur im Normalbetrieb
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										In Abbildung 4-1 ist eine Übersicht über die
										Reglerstruktur des Luftpfades
										dargestellt, sowie die Berechnung
										der Einspritzzeit und des Zündwinkels. Damit
										wird im
										Normalbetrieb aus dem Momentenwunsch des Fahrers ein
										Sollsaugrohrdruck berechnet. Auf Grund dieses Saugrohrdruckes
										berechnet die
										Motorsteuerung mit Hilfe des Saugrohrdruckreglers
										eine
										Solldrosselklappenstellung, welche dann vom
										Drosselklappenregler eingeregelt
										wird. Wird ein größerer
										Saugrohrdruck benötigt als saugmotorisch bereitgestellt
										werden
										kann, wird der Wastegateregler aktiv und die Drosselklappe
										wird 100%
										geöffnet. Über die Stellung des Wastegates
										(Bypassventil des Turboladers) wird
										der Saugrohrdruck geregelt.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>isc_png_2</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Reglerstruktur bei aktivem Leerlaufregler
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Ist der Motor in Leerlaufbetrieb (Abbildung 4-2),
										wird die Sollleerlaufdrehzahl mit
										Hilfe des Leerlaufreglers
										geregelt. Der Regler hat dabei zwei Stellgrößen die
										beeinflusst werden. Zum einen wird der Saugrohrdruck über die
										Drosselklappenstellung beeinflusst und zum anderen wird der
										Zündwinkel und
										hiermit das Moment beeinflusst.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Leerlaufregler</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Leerlaufregler</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Der Leerlaufregler befindet sich im Funktionsmodul
										IdleSpeedController (Isc). In
										diesem Modul werden die
										Korrekturgrößen berechnet, welche zur Regelung der
										Leerlaufdrehzahl notwendig sind. Außerdem werden die
										Bedingungen für den
										aktiven Leerlaufregler abgefragt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										<E TYPE="BOLD">Bedingungen für aktive Leerlaufregelung:</E>
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Die Leerlaufregelung darf nur in bestimmten
										Betriebszuständen des Motors aktiv
										sein. In der Motorsteuerung
										sind daher Bedingungen zu erfüllen. Zum einen ist die
										Regelung
										nur aktiv, sobald die Drehzahl in einem bestimmten Bereich
										liegt. Mit
										den Parametern Isc_rpmIdleCtrlActivMin und
										Isc_rpmIdleCtrlActivMax sind diese
										Grenzen parametrierbar. Zum
										anderen wird mit dem Parameter Isc_facEgasMin
										die maximale
										Gaspedalstellung, bei der die Regelung noch aktiv ist,
										parametriert.
										Zusätzlich wird bei aktivem Starter
										(Stc_flgStarterActive_Sim = true) oder manuell über
										das Label
										Isc_flgIdleSpeedCtrlEnable = false (Standardeinstellung ist
										true) die
										Regelung deaktiviert.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>Isc.Isc_mdl.CalcIdleConditions</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Erfassung der Bedingungen für aktiven
												Leerlaufregler
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										<E TYPE="BOLD">Berechnung der Korrekturgrößen:</E>
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Der Leerlaufregler regelt die Drehzahl über 2
										Verstellgrößen. Zum einen über die
										Drosselklappe und zum
										anderen über die Zündwinkeladaption.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										In der Motorsteuerung wird dazu ein Proportional-
										und ein Integral-Anteil gebildet.
										Die Drosselklappe ist dabei
										nur vom I-Anteil1 beeinflusst. Der Zündwinkel dagegen
										zusätzlich vom schnellen P-Anteil2. Die Verstärkungsfaktoren
										der beiden Anteile
										werden in Abhängigkeit der Differenz von
										Soll-Motordrehzahl und Ist-
										Motordrehzahl gebildet. Je größer
										die Differenz ist, desto höher sind die
										Verstärkungsfaktoren.
										Parametrierbar sind diese Verstärkungsfaktoren in den
										Kennfeldern Isc_facPPart_CUR (P-Anteil) und Isc_facIPart_CUR
										(I-Anteil).
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>Isc.Isc_mdl.P_and_I_Calculation</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Berechnung P- und I-Anteil des Leerlaufreglers
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Der P-Anteil (
										<TT TYPE="VARIABLE">Isc_IdleSpdCtrlPPart_Sim</TT>
										) entspricht dem aus
										<TT TYPE="PRM">Isc_facPPart_CUR</TT>
										gebildeten Verstärkungsfaktor. Beim I-Anteil (
										<TT TYPE="VARIABLE">Isc_IdleSpdCtrlIPart_Sim</TT>
										) wird der
										Verstärkungsfaktor
										<TT TYPE="PRM">Isc_facIPart_CUR</TT>
										als Eingang des Integrators verwendet. Die
										Grenzen des
										Integrators werden mit den Parametern
										<TT TYPE="PRM">Isc_IPartMax</TT>
										und
										<TT TYPE="PRM">Isc_IPartMin</TT>
										nach oben und unten begrenzt.
										Delta T des Integrators wird auf 0,01s gesetzt, da diese Funktion
										im 10ms Raster ausgeführt wird.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Eine Art Vorsteuerung bildet der Stabilisierungsfaktor
										<TT TYPE="VARIABLE">Isc_facIdleSpdStab_Sim</TT>
										, der auf
										das Schleppmoment des Motors multipliziert wird.
										Dieser Faktor wird gebildet aus
										der Soll-Leerlaufdrehzahl und
										der Ist-Motordrehzahl und bewirkt eine Anhebung
										der
										Momentenanforderung, je niedriger die Motordrehzahl desto
										höher der Faktor
										und damit die Momentenanforderung.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>isc_png_5</SHORT-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>

								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>Isc.Isc_mdl.P_and_I_Calculation.Integrator</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Integrator
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="JPG" SCALE="0.61">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>


								<P>
									<L-1 L="DE">
										Wird keine Momentenanforderung durch Betätigen des
										Gaspedals gestellt, sinkt
										die Drehzahl des Motors ab, solange
										bis der Leerlaufregler die gewünschte
										Drehzahl einregelt. Um
										ein sanfteres Einregelverhalten zu erreichen, wird der
										Leerlaufregler bereits über der Soll-Leerlaufdrehzahl
										aktiviert. Die Solldrehzahl,
										die zum Aktivierungszeitpunkt des
										Leerlaufreglers der Motordrehzahl entspricht,
										wird dann über
										einen Integrator verzögert abgesenkt bis die gewünschte
										Leerlaufdrehzahl erreicht ist.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>isc_png_6</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Beeinflussung Saugrohrdruck durch den
												Leerlaufregler
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Im Folgenden wird erläutert wie der Leerlaufregler
										funktioniert und auf welche
										Größen er Einfluss hat. In
										Abbildung 4-5 ist dargestellt wie der P- und der I-Anteil
										des
										Leerlaufreglers auf den Saugrohrdruck einwirken. Aus dem
										Sollsaugrohrdruck
										der in der Momentenstruktur berechnet wird,
										wird ein "schneller“ und ein
										"langsamer“ Saugrohrdruck
										gebildet. Auf den „schnellen“ Saugrohrdruck, der auf
										den
										Zündwinkel wirkt, werden sowohl P- als auch I-Anteil addiert.
										Auf den "langsamen" Saugrohrdruck werden der I-Anteil und die
										Momentenreserve
										(vorgegeben über
										<TT TYPE="PRM">T2t_pManiRes</TT>
										) addiert. Dadurch wird der Zündwinkel
										wesentlich schneller
										geregelt als die Drosselklappe, was zur Folge hat, dass eine
										plötzliche Lastmomentänderung über den Zündwinkel ausgeglichen
										wird bis die
										Drosselklappe nachfolgt.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>isc_png_7</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Adaption des Zündwinkels durch den Leerlaufregler
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Aus dem "schnellen" Saugrohrdruck und dem
										Ist-Saugrohrdruck wird in Abbildung
										4-6 der minimale
										Saugrohrdruck, der durch den Saugrohdrucksensor begrenzt
										wird,
										subtrahiert und anschließend der Quotient gebildet. Dies
										ergibt den
										Zündwinkelwirkungsgrad, der notwendig ist die
										Drehzahl stabil zu regeln. Durch
										das
										Zündwinkelwirkungsgrad-Kennfeld wird aus dem Wirkungsgrad, der
										Differenz
										Zündwinkel berechnet und vom vorgesteuerten
										Zündwinkel abgezogen. Eine
										Simulation des Leerlaufreglers gegen
										LABCAR ist in Kapitel 6.1 beschrieben.
									</L-1>
								</P>
							</CHAPTER>
							<CHAPTER>
								<SHORT-NAME>Schubbetrieb</SHORT-NAME>
								<LONG-NAME>
									<L-4 L="EN">Schubbetrieb</L-4>
								</LONG-NAME>
								<P>
									<L-1 L="DE">
										Im Schubbetrieb wird kein abgegebenes Moment des
										Motors benötigt. Da der
										Saugrohrdruck nie auf null gehen kann
										und der Motor mit einem
										stöchiometrischen
										Luft-Kraftstoffverhältnis betrieben wird, gibt der Motor
										trotzdem
										ein Moment ab. Deshalb soll nach einer bestimmten
										Zeit, nach Erfüllung der
										Bedingungen, die Einspritzung
										abgeschaltet werden. Die Einspritzung wird nicht
										sofort
										unterbrochen, da ein zu starkes Ruckeln des Motors vermieden
										werden soll.
										Während der aktiven Schubabschaltung ist der
										Lambdaregler inaktiv geschaltet.
									</L-1>
								</P>
								<FIGURE>
									<FIGURE-CAPTION>
										<SHORT-NAME>Isc.Isc_mdl.Schubabschaltung</SHORT-NAME>
										<LONG-NAME>
											<L-4 L="DE">
												Programmausschnitt Schubbetrieb
											</L-4>
										</LONG-NAME>
									</FIGURE-CAPTION>
									<L-GRAPHIC L="FOR-ALL">
										<GRAPHIC NOTATION="PNG" SCALE="0.71">
										</GRAPHIC>
									</L-GRAPHIC>
								</FIGURE>
								<P>
									<L-1 L="DE">
										Bedingungen für die Aktivierung der Schubabschaltung
										(Abbildung 4-8):
									</L-1>
								</P>
								<LIST TYPE="UNNUMBER">
									<ITEM>
										<P>
											<L-1 L="DE">EGas1-Stellung parametrierbar über Isc_facEgasMin
											</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">Drehzahl über der Schwellendrehzahl des
												Leerlaufreglers(Isc_rpmIdleCtrlActivMax)</L-1>
										</P>
									</ITEM>
									<ITEM>
										<P>
											<L-1 L="DE">
												Schubabschaltung freigegeben (
												<TT TYPE="PRM">Isc_FuelCutoffEnable</TT>
												= "true")
											</L-1>
										</P>
									</ITEM>
								</LIST>
								<P>
									<L-1 L="DE">
										Die verzögerte Aktivierung der Schubabschaltung erfolgt über
										einen Counter.
										Dieser wird aktiv, sobald die Bedingungen
										erfüllt sind. Ist die Schubabschaltung
										nicht aktiv, wird der
										Counter zurückgesetzt. Mit Hilfe des Parameters
										<TT TYPE="PRM">Isc_FuelCutoffDelay</TT>
										wird die Zeitverzögerung der Schubabschaltung in Sekunden
										vorgegeben. Ist die Verzögerung erreicht, wird
										<TT TYPE="VARIABLE">Isc_flgFuelCutoff_Sim</TT>
										auf "true" gesetzt.
									</L-1>
								</P>
								<P>
									<L-1 L="DE">
										Sobald der Motor im Schubmodus ist, wird mit Hilfe von
										<TT TYPE="VARIABLE">Isc_flgFuelCutoff_Sim</TT>
										die
										Lambdaregelung deaktiviert und die Einspritzung
										unterbrochen.
									</L-1>
								</P>
							</CHAPTER>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
