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
						<SHORT-NAME>Injection Time Calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Injection Time Calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Itc Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>InjectionTime.Main</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Einspritzzeit</SHORT-NAME>
							<P>
								<L-1 L="DE">
									Im Modul Einspritzzeit (InjectionTime) wird die Kraftstoffmasse
									<TT TYPE="PRM">Fmc_mFuel</TT>
									in die Ein-
									-spritzzeit Itc_tiInj gewandelt, evaluiert, ob eine
									Einspritzung
									<TT TYPE="VARIABLE">Itc_flgInjCutoff</TT>
									= true
									stattfinden muss und die batteriespannungsabhängige
									Verzugszeit
									<TT TYPE="VARIABLE">Itc_tiBattDelay</TT>
									der
									Einspritzdüsen berechnet. Nach dem vollständigen Öffnen und
									vor dem Schließbeginn des
									Einspritzventils besteht ein linearer
									Zusammenhang zwischen der eingespritzten Kraftstoff-
									menge und
									der Öffnungszeit. Die Geradengleichung (s. Gleichung 5.11)
									entsteht durch eine
									statische und eine dynamische Menge. Zur
									Berechnung der Einspritzzeit aus der Kraft-
									stoffmenge ist die
									Umkehrfunktion ist in der Kennlinie
									<TT TYPE="PRM">Itc_mFuelMass2tiInjBase_CUR</TT>
									hinterlegt.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Während des Öffnens ist das Verhältnis nicht linear
									und muss bei Bedarf durch Versuche
									ermittelt werden. Die
									Nichtlinearität durch das Schließen des Ventils kann
									vernachlässigt
									werden, da im Steuergerät explizit eine
									Löschdiode verbaut ist, die den Spulenstrom sehr
									schnell abbaut,
									wodurch das Ventil sehr schnell geschlossen wird.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Ein Aussetzen der Einspritzung erfolgt bei:
								</L-1>
							</P>
							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">
											einer Einspritzzeit kleiner
											<TT TYPE="PRM">Itc_tiInjMin</TT>
											= 2000µs
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">einer Drehzahl kleiner 30 1/min</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">
											einer Drehzahl größer
											<TT TYPE="PRM">Itc_rpmEngSpdMax</TT>
											= 6000 1/min (maximale Drehzahl &#x2012; Wiedereinsetzen gesteuert
											durch Hysterese
											<TT TYPE="PRM">Itc_rpmEngSpdHyst</TT>
											= 150 1/min bei 5850 1/min)
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">
											einem Saugrohrdruck von mehr als
											<TT TYPE="PRM">Itc_pManiFiltMax</TT>
											= 2000hPa
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">eeiner Aussetzung der Zündung um zu vermeiden, dass
											Kraftstoff unverbannt in das
											Abgassystem gerät
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">
											dem Setzen des Flags
											<TT TYPE="PRM">Itc_flgInjCutoffMan</TT>
										</L-1>
									</P>
								</ITEM>
							</LIST>
							<P>
								<L-1 L="DE">
									Um zu vermeiden im nichtlinearen Bereich der
									Einspritzventile zu arbeiten, wird bei einer
									Einspritzzeit
									unterhalb 2ms abgeschalten.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Einspritzabschaltung aufgrund eines zu hohen
									Saugrohrdrucks wird aus Sicherheits-
									gründen durchgeführt. Im
									Motor ist kein Ladedrucksensor verbaut, d. h., der Ladedruck
									kann nicht direkt gemessen werden, sondern nur auf Basis von
									Drehzahl, Saugrohrdruck,
									Drosselklappenstellung und
									Wastegatestellung abgeschätzt werden. Dabei können sehr
									leicht
									Fehler passieren, was eine Zerstörung des Abgasturboladers zur
									Folge haben könnte.
									Um dies zu verhindern, wird im Modul
									Momentenumrechnung Abschnitt 5.6.8 festgelegt,
									dass bei Drücken
									über 1500hPa die Drosselklappe immer vollständig geöffnet ist
									und
									dadurch die Annahme getroffen, dass der Druck vor
									Drosselklappe dem Saugrohrdruck
									entspricht. Sobald also der
									maximal gewünschte Ladedruck von 1bar erreicht ist, wird
									ausgesetzt (pmax = pUmgebung + pAufladung,max).
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die batteriespannungsabhängige Verzugszeit
									<TT TYPE="VARIABLE">Itc_tiBattDelay</TT>
									wird aus der Batteriespan-
									nung
									<TT TYPE="VARIABLE">Bvc_uBatt</TT>
									über die Kennlinie
									<TT TYPE="PRM">Itc_uBatt2tiBattDelay_CUR</TT>
									ermittelt. Sie ist dem
									Funktionsrahmen der Smartmotorsteuerung
									entnommen, liegt für 6V bei rund 2,3ms und
									fällt mit steigender
									Spannung in Form einer Exponentialfunktion auf 0ms ab, die
									bereits
									bei rund bis 14V erreicht werden.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Gleichung 5.11 zeigt den Zusammenhang zwischen
									Einspritzmenge und Einspritzzeit im
									linearen Bereich (s. auch
									Abschnitt A.8).
								</L-1>
							</P>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>itc_png_1</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="PNG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
							<P>
								<L-1 L="DE">
									Die Auswertung der Funktion Itc_calc erfolgt im
									Synchron-Raster. Durch das Flag
									<TT TYPE="PRM">Itc_flgInjTimeOverride</TT>
									kann die Einspritzzeit manuell mit
									<TT TYPE="PRM">Itc_tiInjMan</TT>
									überschrieben
									werden, bevor sie als Nachricht weitergereicht
									wird.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
