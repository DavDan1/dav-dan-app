import ChuckNorrisJoke from '../components/ChuckNorrisJoke';

const IndexPage: React.FC = () => {
  const getJoke = async (): Promise<string> => {
    try {
      const response = await fetch(
        'https://weather-app-davitdanielyan-e3uzzxqbva-uc.a.run.app/api/ChuckNorris/random-jok',
      );
      const data = await response.json();
      return data;
    } catch (error) {
      console.error('Error fetching data:', error);
      return 'Failed to fetch Chuck Norris Joke';
    }
  };

  return <ChuckNorrisJoke getJoke={getJoke} />;
};

export default IndexPage;
