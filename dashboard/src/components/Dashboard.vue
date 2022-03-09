<template>
  <div>
    <div class="cards">
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Todays Money</h4>
          <div class="card-info df jc-sb">
            <h3>$53,000</h3>
            <h5>+55%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/money-coins.svg" alt="money">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Today’s Users</h4>
          <div class="card-info df jc-sb">
            <h3>2,300</h3>
            <h5>+20%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/world.svg" alt="world">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">New Clients</h4>
          <div class="card-info df jc-sb">
            <h3>+3,462</h3>
            <h5 style="color: #EA0606">-2%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/paper-diploma.svg" alt="paper-diploma">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Sales</h4>
          <div class="card-info df jc-sb">
            <h3>$103,430</h3>
            <h5>+5%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/money-coins.svg" alt="money">
        </div>
      </div>
    </div>
    <div class="Banners">
      <div class="banner df jc-sb b60 bg-b1">
        <div class="banner-text">
          <p>Built by developers</p>
          <p>Soft UI Dashboard</p>
          <p style="hyphens: auto">From colors, cards, typography to complex elements, you
             will find the full documentation.</p>
          <div class="ReadMore df" style="color: #67748E">
            <p>Read More</p>
            <img src="../assets/Path.svg" alt="Path">
          </div>
        </div>
        <div class="banner-img">
          <img src="../assets/info-card.jpg" alt="info">
        </div>
      </div>
      <div class="banner df jc-sb b40">
        <div class="banner2">
          <h3 style="font-size: 20px">Work with the rocket</h3>
          <h4 style="font-size: 16px">Wealth creation is an evolutionarily recent positive-sum game.
            It is all about who take the opportunity first.</h4>
          <div class="ReadMore df" style="color: white">
            <p>Read More</p>
            <img src="../assets/arrow-right.svg" alt="Path">
          </div>
        </div>
      </div>
    </div>
    <div class="Statistick">
      <div class="banner stat-banner b40">
        <img src="../assets/chart.jpg" alt="chart" class="stat-img">
        <p>Active Users</p>
        <p>(+23%) than last week</p>
        <div class="statisticInfo">
          <div class="stat">
            <div class="stat-tittle df">
              <img src="../assets/doc.jpg" alt="doc">
              <h6>Users</h6>
            </div>
            <div class="stat-body">
              <h3>3,6K</h3>
              <img src="../assets/progressbar.svg" alt="progressbar">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <img src="../assets/rocket.jpg" alt="rocket">
              <h6>Clicks</h6>
            </div>
            <div class="stat-body">
              <h3>2m</h3>
              <img src="../assets/progressbar.svg" alt="progressbar">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <img src="../assets/card.jpg" alt="card">
              <h6>Sales</h6>
            </div>
            <div class="stat-body">
              <h3>$772</h3>
              <img src="../assets/progressbar2.svg" alt="progressbar">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <img src="../assets/setting.jpg" alt="setting">
              <h6>Items</h6>
            </div>
            <div class="stat-body">
              <h3>82</h3>
              <img src="../assets/progressbar3.svg" alt="progressbar">
            </div>
          </div>
        </div>
      </div>
      <div class="banner b60">
        <div class="title">
          <p>Sales Overview</p>
          <div class="df" style="margin-bottom: 60px">
            <img src="../assets/arrow-top.svg" alt="arrow-top">
            <h4>4% more in 2021</h4>
          </div>
        </div>
        <img src="../assets/graf.jpg" alt="graf" class="graf">
      </div>
    </div>
  </div>
</template>

<script lang='ts'>
import Vue from 'vue';

export default {
};
</script>

<style scoped>
  .df{
    display: flex;
  }
  .jc-sb{
    justify-content: space-between;
  }
  .cards{
    width: 98%;
    display: grid;
    grid-template-columns: repeat(4, 24%);
    gap: 0 14px;
  }
  .card{
    background-color: #fff;
    border-radius: 16px;
    padding: 16px;
  }
  .card-title{
    font-size: 14px;
    color: #67748E;
  }
  .card-info h3{
    font-size: 20px;
    color: #252F40;
    margin: 0;
  }
  .card-info h5{
    font-size: 14px;
    color: #82D616;
    margin: 0;
    margin: 6px 0px 0px 4px;
  }
  .card-text h4{
    margin: 0;
    margin-bottom: 6px;
  }
  .card-img{
    width: 48px;
    height: 48px;
    background: linear-gradient(135deg, #FF0080 0%, #7928CA 100%);
    box-shadow: 0px 4px 6px -1px rgba(0, 0, 0, 0.12), 0px 2px 4px -1px rgba(0, 0, 0, 0.07);
    border-radius: 8px;
  }
  .card-img img{
    margin-top: 14px;
    margin-left: 14px;
  }

  .Banners{
    display: flex;
    justify-content: space-between;
    margin: 24px 0px;
    max-width: 98%;
  }
  .banner{
    padding: 16px;
    background: #FFFFFF;
    box-shadow: 0px 20px 27px rgba(0, 0, 0, 0.05);
    border-radius: 16px;
  }
  .b60{
    width: 56%;
  }
  .b40{
    width: 36%;
  }
  .banner-text{
    position:relative;
  }
  .banner-text :not(:nth-child(2)){
    margin: 0;
    font-size: 16px;
    color: #67748E;
  }
  .ReadMore{
    position:absolute;
    bottom:0;
    align-items: center;
    font-size: 14px;
  }
  .ReadMore img{
    margin-top: 2px;
    margin-left: 10px;
  }
  .banner-img{
    width: 247px;
    height: 221px;
  }
  .banner2{
    position:relative;
    color: #FFFFFF;
    background: url(../assets/image.jpg);
    background-size: 100% 100%;
    background-repeat: no-repeat;
  }
  .banner2 :nth-child(-n+2):not(img)
  {
    margin-left: 16px;
  }

  .Statistick{
    width: 98%;
    display: flex;
    justify-content: space-between;
  }
  .statisticInfo{
    width: 98%;
    display: grid;
    grid-template-columns: repeat(4, 24%);
    gap: 0 14px;
  }
  .stat-tittle img{
    width: 21px;
    height: 21px;
  }
  .stat-tittle h6{
    margin: 0;
    font-size: 14px;
    color: #67748E;
  }
  .stat-body h3{
    margin: 0;
    font-size: 24px;
    color: #252F40;
  }
  .stat-banner{
    color: #252F40;
  }
  .title p{
    margin: 0;
    font-size: 16px;
    color: #252F40;
  }
  .title h4{
    font-size: 14px;
    color: #67748E;
  }
  .stat-img{
      width: 100%;
    }
  .graf{
    width: 100%;
  }
  @media (max-width: 420px){
    .cards{
      width: 110%;
      grid-template-columns: repeat(1, 90%);
      gap: 0 14px;
      margin-left: -10%;
    }
    .card
    {
      margin-bottom: 10px;
    }
    .Banners{
      display: block;
    }
    .banner-img{
      display: none;
    }
    .bg-b1{
      height: 200px;
      background: linear-gradient(rgba(43, 41, 41, 0.7),
      rgba(0, 0, 0, 0.8)), url(../assets/info-card.jpg);
      background-repeat: no-repeat;
      background-size: 100% 100%;
    }
    .b40{
      width: 90%;
      margin-left: -10%;
      height: 220px;
    }
    .b60{
      width: 90%;
      margin-left: -10%;
      margin-bottom: 10px;
    }
    .banner2{
      background-repeat: no-repeat;
      background-size: 100% 100%;
    }
    .Statistick{
      display: block;
    }
    .statisticInfo{
    width: 98%;
    display: grid;
    grid-template-columns: repeat(2, 48%);
    gap: 0 10px;
    margin-left: 6%;
    }
    .stat-banner{
      height: 340px;
      margin-bottom: 10px;
    }
  }
</style>
