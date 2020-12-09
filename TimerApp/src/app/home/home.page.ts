import { Component } from '@angular/core';
import { Insomnia } from '@ionic-native/insomnia/ngx';
import { TextToSpeech } from '@ionic-native/text-to-speech/ngx';
import { Interval } from '../common/interval';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  currentInterval: Interval = new Interval("Remaining time", 1, 0, 0);
  totalTime: Interval = new Interval("Total Time", 0, 0, 0);
  remainingTime: Interval;

  headerTitle: string = "00:00.0";

  timerPercent: number = 100;
  timerTitle: string = "00:00.0";
  timerSubtitle: string = "";

  isStarted: boolean = false;
  isRunning: boolean = false;

  datePickerValue: string;

  private loopInterval: any;
  
  constructor(private tts: TextToSpeech, private insomnia: Insomnia) {}

  ngOnInit(): void {
    this.remainingTime = this.currentInterval.clone();
    this.updateUI();
  }

  onDatePickerChanged(){
    let date  = new Date(this.datePickerValue);
    this.remainingTime = new Interval("Interval", date.getMinutes(), date.getSeconds(), 0);
    this.currentInterval = this.remainingTime.clone();
    this.updateUI();
  }

  private updateUI()
  {
    this.timerPercent = this.remainingTime.divide(this.currentInterval) * 100;
    this.timerTitle = this.remainingTime.format();
    this.headerTitle = this.totalTime.format();
  }

  timerClicked()
  {
    if(!this.isStarted)
      this.start();
    
    this.togglePause();
  }

  private start()
  {
    this.isStarted = true;
    
    this.loopInterval = setInterval(() => this.loop(), 100)
    this.totalTime.subMs(100);
    
  }

  private togglePause()
  {
    this.isRunning = !this.isRunning;

    if(this.isRunning)
    {
      this.timerSubtitle = "GO!"
      this.insomnia.keepAwake();
    }
    else
    {
      this.insomnia.allowSleepAgain();
      this.timerSubtitle = "Paused"
    }
  }

  private loop()
  {
    if(!this.isRunning)
      return;
    
    // TODO: Add multiple intervals

    if(this.remainingTime.minutes == 0 && this.remainingTime.seconds == 10 && this.remainingTime.miliSeconds == 0)
      this.tts.speak("Ten seconds remaining.")
        .then(() => console.log("Spoken"))
        .catch((err) => console.log(err))

    if(!this.remainingTime.subMs(100))
    this.togglePause();
    
    this.totalTime.addMs(100);
    this.updateUI();
  }

  restart() 
  {
    this.remainingTime = this.currentInterval.clone();
    this.updateUI();
  }

  reset() 
  {
    this.totalTime = new Interval("Total time", 0, 0, 0);
    this.remainingTime = this.currentInterval.clone();
    this.updateUI();
  }
}
